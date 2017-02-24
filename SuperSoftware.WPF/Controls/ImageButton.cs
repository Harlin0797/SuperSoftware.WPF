using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SuperSoftware.WPF.Controls
{
    /// <summary>
    /// 图片按钮
    /// </summary>
    public class ImageButton : Button
    {
        /// <summary>
        /// 静态构造重写默认样式元数据
        /// </summary>
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        #region Properties

        #region 图像相关

        /// <summary>
        /// 获取或设置图像。
        /// </summary>
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(null));


        /// <summary>
        /// 获取或设置图像高度。
        /// </summary>
        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }
        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(ImageButton), new PropertyMetadata(Double.NaN));


        /// <summary>
        /// 获取或设置图像宽度。
        /// </summary>
        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(ImageButton), new PropertyMetadata(Double.NaN));

        /// <summary>
        /// 获取或设置图像的外边距。
        /// </summary>
        public Thickness ImageMargin
        {
            get { return (Thickness)GetValue(ImageMarginProperty); }
            set { SetValue(ImageMarginProperty, value); }
        }
        public static readonly DependencyProperty ImageMarginProperty =
            DependencyProperty.Register("ImageMargin", typeof(Thickness), typeof(ImageButton), new PropertyMetadata(new Thickness(2, 0, 2, 0)));

        #endregion


        /// <summary>
        /// 获取或设置元素圆角半径
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ImageButton), new PropertyMetadata(default(CornerRadius)));

        #region 鼠标悬停相关

        /// <summary>
        /// 获取或设置鼠标悬停的背景
        /// </summary>
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(ImageButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"))));

        /// <summary>
        /// 获取或设置鼠标悬停的边框
        /// </summary>
        public Brush MouseOverBorderBrush
        {
            get { return (Brush)GetValue(MouseOverBorderBrushProperty); }
            set { SetValue(MouseOverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBorderBrushProperty =
            DependencyProperty.Register("MouseOverBorderBrush", typeof(Brush), typeof(ImageButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"))));

        /// <summary>
        /// 获取或设置鼠标悬停的前景
        /// </summary>
        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverForegroundProperty =
            DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(ImageButton),
                new PropertyMetadata(new SolidColorBrush(SystemColors.ControlTextColor)));


        #endregion

        #region 鼠标按下相关

        /// <summary>
        /// 获取或设置鼠标按下的背景
        /// </summary>
        public Brush PressedBackground
        {
            get { return (Brush)GetValue(PressedBackgroundProperty); }
            set { SetValue(PressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register("PressedBackground", typeof(Brush), typeof(ImageButton),
                   new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"))));

        /// <summary>
        /// 获取或设置鼠标按下的边框
        /// </summary>
        public Brush PressedBorderBrush
        {
            get { return (Brush)GetValue(PressedBorderBrushProperty); }
            set { SetValue(PressedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty PressedBorderBrushProperty =
            DependencyProperty.Register("PressedBorderBrush", typeof(Brush), typeof(ImageButton),
                 new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"))));

        /// <summary>
        /// 获取或设置鼠标按下的前景
        /// </summary>
        public Brush PressedForeground
        {
            get { return (Brush)GetValue(PressedForegroundProperty); }
            set { SetValue(PressedForegroundProperty, value); }
        }

        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.Register("PressedForeground", typeof(Brush), typeof(ImageButton),
                new PropertyMetadata(new SolidColorBrush(SystemColors.ControlTextColor)));


        #endregion


        #region 不可用相关

        /// <summary>
        /// 获取或设置不可用的背景
        /// </summary>
        public Brush DisabledBackground
        {
            get { return (Brush)GetValue(DisabledBackgroundProperty); }
            set { SetValue(DisabledBackgroundProperty, value); }
        }

        public static readonly DependencyProperty DisabledBackgroundProperty =
            DependencyProperty.Register("DisabledBackground", typeof(Brush), typeof(ImageButton),
                   new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"))));

        /// <summary>
        /// 获取或设置不可用的边框
        /// </summary>
        public Brush DisabledBorderBrush
        {
            get { return (Brush)GetValue(DisabledBorderBrushProperty); }
            set { SetValue(DisabledBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty DisabledBorderBrushProperty =
            DependencyProperty.Register("DisabledBorderBrush", typeof(Brush), typeof(ImageButton),
                  new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"))));

        /// <summary>
        /// 获取或设置不可用的前景
        /// </summary>
        public Brush DisabledForeground
        {
            get { return (Brush)GetValue(DisabledForegroundProperty); }
            set { SetValue(DisabledForegroundProperty, value); }
        }

        public static readonly DependencyProperty DisabledForegroundProperty =
            DependencyProperty.Register("DisabledForeground", typeof(Brush), typeof(ImageButton),
                  new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"))));

        #endregion


        //HorizontalAlignment
        //#region 阴影相关

        ///// <summary>
        ///// 阴影深度，默认值5
        ///// </summary>
        //public double ShadowDepth
        //{
        //    get { return (double)GetValue(ShadowDepthProperty); }
        //    set { SetValue(ShadowDepthProperty, value); }
        //}

        //public static readonly DependencyProperty ShadowDepthProperty =
        //    DependencyProperty.Register("ShadowDepth", typeof(double), typeof(ImageButton), new PropertyMetadata(Double.NaN));

        ///// <summary>
        ///// 阴影
        ///// </summary>
        //public DropShadowEffect DropShadowEffect
        //{
        //    get { return (DropShadowEffect)GetValue(DropShadowEffectProperty); }
        //    set { SetValue(DropShadowEffectProperty, value); }
        //}

        //public static readonly DependencyProperty DropShadowEffectProperty =
        //    DependencyProperty.Register("DropShadowEffect", typeof(DropShadowEffect), typeof(ImageButton), new PropertyMetadata(default(DropShadowEffect)));


        //#endregion




        #endregion




    }
}
