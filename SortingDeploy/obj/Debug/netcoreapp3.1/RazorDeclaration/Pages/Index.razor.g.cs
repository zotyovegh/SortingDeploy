#pragma checksum "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c908db4fbab82fc2b5b22cd9054b6fef280c20c9"
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
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using SortingDeploy.Data;

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
#line 33 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
       

    SortingMethods srt = new SortingMethods();

    private int arraySize = 10;
    private int[] array;
    private string stro = "";
    private string strr = "";
    private string sortingType;
    private int numberOfRandoms;
    private int rangeOfRandoms;
    private int printNumber;
    private int printRange;
    private int actual;



    private async void Randomize()
    {

        array = new int[numberOfRandoms];
        arraySize = numberOfRandoms;

        stro = "";
        strr = "";
        srt.CreateRandomArray(arraySize, array, rangeOfRandoms);


        for (int i = 0; i < array.Length; i++)
        {
            stro = stro + " " + array[i];
        }

        if (sortingType == "Bubble Sort")
        {
            await srt.BubbleSort(array, arraySize); //meg itt

            for (int i = 0; i < array.Length; i++)
            {
                strr = strr + " " + array[i];
            }
            strr = strr + " Bubble";
        }
        else if (sortingType == "Selection Sort")
        {
            srt.SelectionSort(array, arraySize);

            for (int i = 0; i < array.Length; i++)
            {
                strr = strr + " " + array[i];
            }
            strr = strr + " Selection";
        }
        else if (sortingType == "Insertion Sort")
        {
            srt.InsertionSort(array, arraySize);

            for (int i = 0; i < array.Length; i++)
            {
                strr = strr + " " + array[i];
            }
            strr = strr + " Insertion";
        }

        printNumber = numberOfRandoms;
        printRange = rangeOfRandoms;


    }

    public void Test()
    {
        srt.Metyod(this);
    }

    public void Update()
    {
        actual = 10;
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
