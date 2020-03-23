#pragma checksum "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f6866ff567f07af19520944b1d345732bd6080"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SortingDeploy.Pages.Components
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using SortingDeploy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using SortingDeploy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Components\Chart.razor"
      
    [Parameter] public int[] array { get; set; }
    [Parameter] public int arraySize { get; set; }
    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet;
    

    protected override void OnInitialized()
    {
        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Simple Bar Chart"
                },

                Responsive = true,
                Scales = new BarScales
                {

                    YAxes = new List<CartesianAxis> {
                        new LinearCartesianAxis {
                            Ticks = new LinearCartesianTicks {
                                AutoSkip = false,
                                Min = 0 // Otherwise the lowest value in the dataset won't be visible

                            }
                        }
                    }
                }


            }
        };







        _barChartConfig.Data.Labels.AddRange(Range());

        _barDataSet = new BarDataset<DoubleWrapper>
        {
            Label = "Estimated time",
            BackgroundColor = "red",
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };


        _barDataSet.AddRange(DoubleArray().Wrap());
        _barChartConfig.Data.Datasets.Add(_barDataSet);

    }

    private double[] DoubleArray()
    {
        List<double> ints = new List<double>();
        for (int i = 0; i < array.Length; i++)
        {
            ints.Add(array[i]);
        }
        double[] d = ints.ToArray();
        return d;
    }

    private string[] Range()
    {
        List<string> t = new List<string>();
        for (int i = 0; i < array.Length; i++)
        {
            t.Add(i + "");
        }
        string[] str = t.ToArray();
        return str;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
