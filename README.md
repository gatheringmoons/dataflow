# Introduction 
This sample demonstrates how to convert a SVG image to a Blazor component.
Using a component to visually show data for up to ten categories.

# Creating SVG
The original SVG image was created using Inkscape. Using the Pen Tool to create the Bezier curves.
Save the file as a Plain SVG file to remove the Inkscape specific markup.

![SVG Mockup](media/lines-plain.png)

# Data
Using the following to define the data for each category. Data is loaded from some sample JSON files.

```
    public class DataFlowItem
    {
        // Index 1 to 10
        public required int Index { get; set; }
        public int StrokeWidth { get; set; } = 1;
        public string StrokeColor { get; set; } = "#000000";
        public string? Text { get; set; }
        public long? Total { get; set; }
        public int? ZIndex { get; set; }
    }
```

# Blazor Component
The Blazor component is made up of a Chart and a Box and Line for each of the ten categories.

The SVG has been converted into the Line component.

```
<svg width="100%" height="100%" preserveAspectRatio="xMinYMin"
         viewBox="0 0 132.02708 124.08958"
        version="1.1"
        id="svg1"
        xmlns="http://www.w3.org/2000/svg"
        xmlns:svg="http://www.w3.org/2000/svg">            

        @if (Index == 1)
        {        
            <g>
                <path class="path" stroke-width="@StrokeWidth" stroke="@StrokeColor"
                      d="M 33.063706,100.52896 C 51.984557,82.181468 70.905406,63.833977 86.099533,54.660231 101.29366,45.486486 112.76062,45.486486 124.2278,45.486486"                      
                      transform="matrix(0.999935,0,0,1.0206023,0.00509974,-2.0759464)" />
            </g>        
        }
        else if (Index == 2)
        ...
    </svg>
```

For main body of SVG within Line component setting the widht and hight to 100% and preserveAspectRatio to xMinYMin.

The Index parameter defines which line is being drawn.

The class path is being used for animation and StrokeWidth and StrokeColor parameters are being used to control line width and color.

# Final Example

![Sample 1](media/example.png)

# Contribute
TODO