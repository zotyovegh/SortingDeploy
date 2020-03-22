#pragma checksum "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db25ea4056a7523f61172bc3a05169cd50afa83"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SortingDeploy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using SortingDeploy.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using SortingDeploy.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
       

    SortingMethods srt = new SortingMethods();
    private bool b = false;
    private int arraySize = 10;
    private int[] array;
    private string stro = "";

    private string sortingType;
    private int numberOfRandoms;
    private int rangeOfRandoms;
    private int printNumber;
    private int printRange;
    private string currentArray;
    private string tempArray;

    protected void Randomize()
    {

        array = new int[numberOfRandoms];
        arraySize = numberOfRandoms;

        stro = "";
        srt.CreateRandomArray(arraySize, array, rangeOfRandoms);


        for (int i = 0; i < array.Length; i++)
        {
            stro = stro + " " + array[i];
        }

        if (sortingType == "Bubble Sort")
        {
            srt.BubbleSort(array, arraySize, this);
        }
        else if (sortingType == "Selection Sort")
        {
            srt.SelectionSort(array, arraySize);
        }
        else if (sortingType == "Insertion Sort")
        {
            srt.InsertionSort(array, arraySize);
        }

        printNumber = numberOfRandoms;
        printRange = rangeOfRandoms;

    }

    public async Task Update(int[] a)
    {
        array = a;

        for (int i = 0; i < array.Length; i++)
        {
            tempArray = tempArray + " " + array[i];
        }

        currentArray = tempArray;
        Debug.WriteLine("We are in the update");

        await Task.Delay(2);
        StateHasChanged();
        Debug.WriteLine(tempArray);
        tempArray = "";

    }

    //private BarConfig _barChartConfig;
    //private ChartJsBarChart _barChart;
    //private BarDataset<DoubleWrapper> _barDataSet;


    //protected override void OnInitialized()
    //{
    //    _barChartConfig = new BarConfig
    //    {
    //        Options = new BarOptions
    //        {
    //            Title = new OptionsTitle
    //            {
    //                Display = true,
    //                Text = "Simple Bar Chart"
    //            },

    //            Responsive = true,
    //            Scales = new BarScales
    //            {
    //                YAxes = new List<CartesianAxis> {
    //                    new LinearCartesianAxis {
    //                        Ticks = new LinearCartesianTicks {
    //                            AutoSkip = false,
    //                            Min = 0 // Otherwise the lowest value in the dataset won't be visible
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    };

    //    _barChartConfig.Data.Labels.AddRange(Range());
    //    _barDataSet = new BarDataset<DoubleWrapper>
    //    {
    //        Label = "Estimated time",
    //        BackgroundColor = "red",
    //        BorderWidth = 0,
    //        HoverBackgroundColor = ColorUtil.RandomColorString(),
    //        HoverBorderColor = ColorUtil.RandomColorString(),
    //        HoverBorderWidth = 1,
    //        BorderColor = "#ffffff"
    //    };

    //    _barDataSet.AddRange(DoubleArray().Wrap());
    //    _barChartConfig.Data.Datasets.Add(_barDataSet);

    //}

    //private double[] DoubleArray()
    //{
    //    if (array != null)
    //    {
    //        List<double> ints = new List<double>();
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            ints.Add(array[i]);
    //        }
    //        double[] d = ints.ToArray();
    //        return d;
    //    }
    //    if(array  == null)
    //    {
    //        List<double> temp = new List<double>();
    //        temp.Add(0);
    //        double[] str = temp.ToArray();
    //        return str;
    //    }
    //    return null;
    //}

    //private string[] Range()
    //{
    //    if (array != null)
    //    {
    //        List<string> t = new List<string>();
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            t.Add(i + "");
    //        }
    //        string[] str = t.ToArray();
    //        return str;
    //    }
    //    if(array  == null)
    //    {
    //        List<string> temp = new List<string>();
    //        temp.Add(" ");
    //        string[] str = temp.ToArray();
    //        return str;
    //    }
    //    return null;
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
