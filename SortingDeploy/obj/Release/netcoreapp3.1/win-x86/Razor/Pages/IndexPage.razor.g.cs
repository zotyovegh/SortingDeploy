#pragma checksum "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f96d7ba4dd0cc657511aadbb10942a51839aa4"
// <auto-generated/>
#pragma warning disable 1591
namespace SortingDeploy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using SortingDeploy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using SortingDeploy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using SortingDeploy.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using SortingDeploy.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class IndexPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Sorting Visualizer by Zoltan Vegh</h1>\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 17 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                        IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                           sortingType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sortingType = __value, sortingType));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "option");
            __builder.AddContent(8, "Bubble Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "option");
            __builder.AddContent(11, "Selection Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "option");
            __builder.AddContent(14, "Insertion Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<p></p>\r\n");
            __builder.AddMarkupContent(17, "<p>Number of randoms:</p>\r\n");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "range");
            __builder.AddAttribute(20, "min", "4");
            __builder.AddAttribute(21, "max", "50");
            __builder.AddAttribute(22, "step", "1");
            __builder.AddAttribute(23, "value", "printSize");
            __builder.AddAttribute(24, "disabled", 
#nullable restore
#line 25 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                                           IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                                                                   (args) => CalcSize(args.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "p");
            __builder.AddContent(28, 
#nullable restore
#line 26 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
    printSize

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.AddMarkupContent(30, "<p>Range of randoms:</p>\r\n");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "range");
            __builder.AddAttribute(33, "min", "5");
            __builder.AddAttribute(34, "max", "100");
            __builder.AddAttribute(35, "step", "1");
            __builder.AddAttribute(36, "value", "printRange");
            __builder.AddAttribute(37, "disabled", 
#nullable restore
#line 28 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                                             IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                                                                     (args) => CalcRange(args.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "p");
            __builder.AddContent(41, 
#nullable restore
#line 29 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
    printRange

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.AddMarkupContent(43, "<p>Delay between actions:</p>\r\n");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "range");
            __builder.AddAttribute(46, "min", "1");
            __builder.AddAttribute(47, "max", "50");
            __builder.AddAttribute(48, "step", "1");
            __builder.AddAttribute(49, "value", "printTime");
            __builder.AddAttribute(50, "disabled", 
#nullable restore
#line 31 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                                           IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                                                                   (args) => CalcTime(args.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.OpenElement(53, "p");
            __builder.AddContent(54, 
#nullable restore
#line 32 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
    printTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                          Sort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "disabled", 
#nullable restore
#line 34 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                                                           IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "style", "height: 300px; width: 500px");
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(65);
            __builder.AddAttribute(66, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 38 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                              _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                            300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                             150

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(69, (__value) => {
#nullable restore
#line 37 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
                           _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\zotyo\Documents\GitHub\SortingDeploy\SortingDeploy\Pages\IndexPage.razor"
       

    SortingMethods srt = new SortingMethods();
    private int arraySize = 10;
    private int[] array;
    private string stro = "";

    private string sortingType = "Bubble Sort";
    private int printSize = 27;
    private int printRange = 52;
    private int printTime = 25;

    private int check;
    public bool IsDisabled { get; set; }
    private bool startScenario;

    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet;

    public void CalcSize(string step)
    {

        printSize = Convert.ToInt32(step);

        Randomize();


    }
    public void CalcRange(string step)
    {
        printRange = Convert.ToInt32(step);

        Randomize();


    }
    public void CalcTime(string step)
    {
        printTime = Convert.ToInt32(step);
    }

    private void Randomize()
    {
        check = 1;

        startScenario = false;
        _barDataSet.RemoveRange(0, arraySize);
        _barChartConfig.Data.Labels.RemoveRange(0, arraySize);

        array = new int[printSize];
        arraySize = printSize;

        stro = "";
        srt.CreateRandomArray(arraySize, array, printRange);
        Update(array);
    }

    private async void Sort()
    {
        DisableCheck();

        if (sortingType == "Bubble Sort")
        {
            srt.BubbleSort(array, arraySize, this, printTime * 7);
        }
        else if (sortingType == "Selection Sort")
        {
            srt.SelectionSort(array, arraySize, this, printTime * 7);
        }
        else if (sortingType == "Insertion Sort")
        {
            srt.InsertionSort(array, arraySize, this, printTime * 7);
        }

    }

    public async Task Update(int[] a)
    {
        array = a;

        if (check == 1)
        {
            _barChartConfig.Data.Labels.AddRange(Range());
        }

        check++;
        if (check > 2)
        {
            _barDataSet.RemoveRange(0, arraySize);

        }

        _barDataSet.AddRange(DoubleArray().Wrap());

        await _barChart.Update();


    }

    protected override void OnInitialized()
    {
        _barChartConfig = new BarConfig
        {
            Options = new BarOptionsSub
            {
                Animation = new Animation()
                {
                    Duration = 0
                },
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
                                Min = 0
                            }
                        }
                    }
                }
            }
        };


        check = 1;
        array = new int[printSize];
        arraySize = printSize;


        srt.CreateRandomArray(arraySize, array, printRange);

        _barDataSet = new BarDataset<DoubleWrapper>
        {
            Label = "",
            BackgroundColor = "red",
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };

        _barDataSet.AddRange(DoubleArray().Wrap());
        _barChartConfig.Data.Datasets.Add(_barDataSet);

        _barChartConfig.Data.Labels.AddRange(Range());

        startScenario = true;
    }

    private double[] DoubleArray()
    {
        List<double> temp = new List<double>();
        if (array != null)
        {
            for (int i = 0; i < array.Length; i++)
            {
                temp.Add(array[i]);
            }
            double[] d = temp.ToArray();
            return d;
        }
        if (array == null)
        {
            double[] d = temp.ToArray();
            return d;
        }
        return null;
    }

    private string[] Range()
    {
        List<string> temp = new List<string>();
        if (array == null)
        {

            string[] str = temp.ToArray();
            return str;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                temp.Add(i + "");
            }
            string[] str = temp.ToArray();
            return str;
        }

    }

    public void DisableCheck()
    {
        if (IsDisabled)
        {
            IsDisabled = false;
        }
        else
        {
            IsDisabled = true;
        }
        if (startScenario)
        {
            _barChartConfig.Data.Labels.RemoveRange(0, arraySize);
            _barDataSet.RemoveRange(0, arraySize);
            startScenario = false;
        }
        StateHasChanged();

    }

    public void IsFirst()
    {
        if (startScenario)
        {
            _barChartConfig.Data.Labels.RemoveRange(0, arraySize);
            _barDataSet.RemoveRange(0, arraySize);
            startScenario = false;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
