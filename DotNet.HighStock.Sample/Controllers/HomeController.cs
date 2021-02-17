﻿using DotNet.HighStock.Enums;
using DotNet.HighStock.Options;
using DotNet.HighStock.Sample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.HighStock.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(string period_type = "day", int time_type = 1, string dealer = "xcoin", string currency = "krw", string coin = "btc", int limit = 365)
        {
            var _period_type = period_type;
            var _time_type = time_type;

            var _dealer = dealer;
            var _currency = currency;
            var _coin = coin;

            var _limit = limit;

            var _trades = await GetTrades(_period_type, _time_type, _dealer, _currency, _coin, _limit);
            var _chart = Demo5(_currency, _coin, _trades.OrderBy(x => x.r_time_value).ToList());

            ViewBag.Stock = _chart;
            return View();
        }

        public async Task<List<ChartDataPeriod>> GetTrades(string period_type, int time_type, string dealer, string currency, string coin, int limit)
        {
            var _result = new List<ChartDataPeriod>();

            var _params = new Dictionary<string, object>();
            {
                _params.Add("period_type", period_type);
                _params.Add("time_type", time_type);
                _params.Add("dealer", dealer);
                _params.Add("currency", currency);
                _params.Add("coin", coin);
                _params.Add("limit", limit);
            }

            //var _received = await HttpClient.CallApiGetAsync<CApiResult<List<ChartDataPeriod>>>("GetTradesOneCurrency", _params);
            //_result = _received.value;

            await Task.Delay(0);

            return _result;
        }

        private HighStock Demo5(string currency, string coin, List<ChartDataPeriod> trades)
        {
            return new HighStock("bpi_chart")
                .SetOptions(new DotNet.HighStock.Helpers.GlobalOptions
                {
                    Global = new Global()
                    {
                        //TimezoneOffset = 540,
                        UseUTC = false
                    }
                })
                .InitChart(new Chart
                {
                    Type = DotNet.HighStock.Enums.ChartTypes.Line,
                    MarginRight = 10,
                    MarginBottom = 25,
                    Height = 900,
                    ClassName = "chart"
                })
                .SetLegend(new Legend
                {
                    Enabled = true,
                    VerticalAlign = VerticalAligns.Bottom,
                    Align = HorizontalAligns.Center,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Series = new PlotOptionsSeries { ShowInLegend = true }
                })
                .SetRangeSelector(new RangeSelector
                {
                    Buttons = new[]
                    {
                        new ButtonsItems{Type = "day", Count = 1, Text = "1d"},
                        new ButtonsItems{Type = "day", Count = 7, Text = "7d"},
                        new ButtonsItems{Type = "month", Count = 1, Text = "1m"},
                        new ButtonsItems{Type = "month", Count = 3, Text = "3m"},
                        new ButtonsItems{Type = "month", Count = 6, Text = "6m"},
                        new ButtonsItems{Type = "all", Text = "All"},
                    },
                    InputEnabled = true,
                    Enabled = true,
                    Selected = 3
                })
                .SetTitle(new Title
                {
                    Text = String.Format("{0}/{1} Chart", coin.ToUpper(), currency.ToUpper()),
                    X = -20
                })
                .SetSubtitle(new Subtitle
                {
                    Text = "Source: bgc-e.com",
                    X = -20
                })
                .SetYAxis(new[]
                {
                    new YAxis
                    {
                        Labels = new YAxisLabels
                        {
                            Align = HorizontalAligns.Right,
                            X = -3
                        },
                        Height = "80%",
                        LineWidth = 2,
                        Title = new YAxisTitle
                        {
                            Text = "Price"
                        }
                    },
                    new YAxis
                    {
                        Labels = new YAxisLabels
                        {
                            Align = HorizontalAligns.Right,
                            X = -3
                        },
                        Top = "85%",
                        Height = "15%",
                        Offset = 0,
                        LineWidth = 2,
                        Title = new YAxisTitle
                        {
                            Text = "Volume"
                        }
                    }
                })
                .SetXAxis(new XAxis
                {
                    Type = AxisTypes.Datetime
                })
                .SetSeries(new[]
                {
                    new Series
                    {
                        Name = "price",
                        Type = ChartTypes.Line,
                        Data = new DotNet.HighStock.Helpers.Data
                            (
                                trades.AsParallel().Select(c => new object[]
                                {
                                    c.r_time_value * 1000,
                                    c.r_close_price
                                }).ToArray()
                            )
                    },
                    new Series
                    {
                        Name = "5days",
                        Type = ChartTypes.Line,
                        Data = new DotNet.HighStock.Helpers.Data
                            (
                                trades.AsParallel().Select(c => new object[]
                                {
                                    c.r_time_value * 1000,
                                    c.r_avg_price_5d
                                }).ToArray()
                            )
                    },
                    new Series
                    {
                        Name = "20days",
                        Type = ChartTypes.Line,
                        Data = new DotNet.HighStock.Helpers.Data
                            (
                                trades.AsParallel().Select(c => new object[]
                                {
                                    c.r_time_value * 1000,
                                    c.r_avg_price_20d
                                }).ToArray()
                            )
                    },
                    new Series
                    {
                        Name = "60days",
                        Type = ChartTypes.Line,
                        DashStyle = DashStyles.Dot,
                        Data = new DotNet.HighStock.Helpers.Data
                            (
                                trades.AsParallel().Select(c => new object[]
                                {
                                    c.r_time_value * 1000,
                                    c.r_avg_price_60d
                                }).ToArray()
                            )
                    },
                    new Series
                    {
                        Name = "120days",
                        Type = ChartTypes.Line,
                        DashStyle = DashStyles.Dot,
                        Data = new DotNet.HighStock.Helpers.Data
                            (
                                trades.AsParallel().Select(c => new object[]
                                {
                                    c.r_time_value * 1000,
                                    c.r_avg_price_120d
                                }).ToArray()
                            )
                    },
                    new Series
                    {
                        Name = "volume",
                        Type = ChartTypes.Column,
                        Data = new DotNet.HighStock.Helpers.Data
                                (
                                    trades.AsParallel().Select(c => new object[]
                                    {
                                        c.r_time_value * 1000,
                                        c.r_sell_volume+c.r_buy_volume
                                    }).ToArray()
                                ),
                        YAxis = "1"
                    }
                });
        }
    }
}
