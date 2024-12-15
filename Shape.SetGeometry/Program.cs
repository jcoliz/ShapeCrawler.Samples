using DocumentFormat.OpenXml.Drawing.Diagrams;
using ShapeCrawler;

var pres = new Presentation();
var shapes = pres.Slides[0].Shapes;

var outerMargin = 0.25m;
var innerMargin = 0m;
var pageWidth = 13 + 1 / 3m;
var pageHeight = 7.5m;
var itemWidth = 1;
var itemHeight = 1;
const decimal dpi = 96m;

var x = outerMargin;
var y = outerMargin;

foreach (var geo in Enum.GetValues(typeof(Geometry)).Cast<Geometry>())
{
    if (geo == Geometry.Custom)
    {
        continue;
    }

    shapes.AddRectangle((int)(x*dpi), (int)(y*dpi), (int)(itemWidth*dpi), (int)(itemHeight*dpi));
    var shape = shapes[^1];
    shape.GeometryType = geo;
    shape.Text = geo.ToString();

    x += itemWidth + innerMargin;
    if (x + itemWidth > pageWidth)
    {
        x = outerMargin;
        y += itemHeight + innerMargin;

        if (y + itemHeight > pageHeight)
        {
            y = outerMargin;
            pres.Slides.AddEmptySlide(SlideLayoutType.Blank);
            shapes = pres.Slides[^1].Shapes;
        } 
    }
}

pres.SaveAs("out/Shape.SetGeometry.pptx");
