#pragma checksum "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "601bd5fcfb518386e9cd38fdaf9d1b3c9c53d1f0"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mesha\Desktop\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Game of Live</h1>\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "environment");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 9 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
     for(var i=0; i<@e.total_of_rows(); i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "         ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 12 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
              for(var j=0; j<@e.total_of_cols(); j++){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
             if(e.biounit(i,j)!=null)
             { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "td");
            __builder.AddAttribute(9, "class", "cell");
            __builder.AddAttribute(10, "style", "background-color:" + (
#nullable restore
#line 15 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                        e.biounit(i,j).myColor()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(11, " \r\n");
#nullable restore
#line 16 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
            } 
            else 
             { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "           <td class=\"cell dead\"></td> \r\n");
#nullable restore
#line 20 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
             
         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 23 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "radio");
            __builder.AddAttribute(20, "name", "myradiobtn");
            __builder.AddAttribute(21, "checked", 
#nullable restore
#line 28 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                     theRadio.Equals("step")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "value", "step");
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                                                                       ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    Step by step\r\n    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "radio");
            __builder.AddAttribute(27, "name", "myradiobtn");
            __builder.AddAttribute(28, "checked", 
#nullable restore
#line 30 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                     theRadio.Equals("many")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "value", "many");
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                                                                       ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    Several steps\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "style", "display:" + (
#nullable restore
#line 35 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                      theRadio.Equals("many")?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n");
            __builder.AddMarkupContent(36, "<h5>Cycle Specification</h5>\r\nNumber of cycles;\r\n\r\n");
            __builder.OpenElement(37, "select");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                 option

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => option = __value, option));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(40, "\r\n");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "1");
            __builder.AddContent(43, "1st");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "2");
            __builder.AddContent(47, "2nd");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", "3");
            __builder.AddContent(51, "3rd");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "4");
            __builder.AddContent(55, "4th");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "5");
            __builder.AddContent(59, "5th");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n<br>\r\nAdd option ");
            __builder.AddContent(62, 
#nullable restore
#line 47 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
            option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "class", "btn btn-primary");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                            IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(68, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n\r\n");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                            AddPatternButton

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, 
#nullable restore
#line 55 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                               PatternMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, " \r\n\r\n");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "my-3");
            __builder.AddAttribute(77, "style", "display:" + (
#nullable restore
#line 57 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                     DisplayButton == true ? "none" : "block"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "\r\n\r\n\r\n");
            __builder.OpenElement(79, "label");
            __builder.AddContent(80, " row ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "type", "number");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                             row

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => row = __value, row, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(86, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
            __builder.OpenElement(88, "label");
            __builder.AddContent(89, " col ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "class", "form-control");
            __builder.AddAttribute(92, "type", "number");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                             col

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => col = __value, col, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(95, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n\r\n");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "class", "btn btn-primary");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                              AddPattern

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, " Add ");
            __builder.AddContent(101, 
#nullable restore
#line 66 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
                                                                PatternName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " Pattern");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(105, "<a class=\"btn btn-primary\" href=\"https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life\" target=\"_blank\">\r\n    Look for Patterns in Wikipedia\r\n</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\mesha\Desktop\blazorserver01\Pages\Counter.razor"
      
    //Defining a valuable for Pattern button

    private string Message { get; set; } = "";
    private bool DisplayButton = true;
    
    private string PatternName = "pentadecathlon";
    private string PatternMessage ="Add Pattern...";
    private int col { get; set; }=0;
    
    private  int row { get; set; } =0;
   
    private String theRadio="";

    private int currentCount = 0;

    private Data.Environment e = new Data.Environment(30,30);
       
    private string option = "";

    private void IncrementCount()
    {
        currentCount++; 
        e.nextConwayStep();
    }

    private void ClickRadio(ChangeEventArgs args){
        theRadio = args.Value.ToString();
        currentCount++;
    }

    private void AddPattern(){
        e.put_pattern(row, col, PatternName);
        row = col = 0;
    }
    private void AddPatternButton(){
        PatternMessage = "Add Pattern " + (DisplayButton ? "(-)" : "...");
        DisplayButton = !DisplayButton;
    } 


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
