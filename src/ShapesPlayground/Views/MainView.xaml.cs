using System;
using Xamarin.Forms;

namespace ShapesPlayground.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        void OnRectangleBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RectangleGallery());
        }

        void OnEllipseBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EllipseGallery());
        }

        void OnLineBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LineGallery());
        }

        void OnPolylineBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolylineGallery());
        }

        void OnPolygonBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolygonGallery());
        }

        void OnPathBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PathGallery());
        }

        void OnPathAspectBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PathAspectGallery());
        }

        void OnPathRenderTransformBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PathRenderTransformGallery());
        }

        void OnClipBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClipGallery());
        }

        void OnClipViewsBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClipViewsGallery());
        }

        void OnClipArtManBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClipArtManGallery());
        }

        void OnBabyElephantBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BabyElephantGallery());
        }

        void OnFromSvgBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FromSvgGallery());
        }
    }
}
