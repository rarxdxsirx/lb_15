using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lb_15
{
    /// <summary>
    /// Логика взаимодействия для DogControl.xaml
    /// </summary>
    public partial class DogControl : UserControl
    {
        public string DogName { 
            get 
            {
                return (string) GetValue(DogNameProperty);
            } 
            set 
            {
                SetValue(DogNameProperty,value);
            }
        }
        public string Breed
        {
            get
            {
                return (string)GetValue(BreedProperty);
            }
            set
            {
                SetValue(BreedProperty, value);
            }
        }
        public string Image
        {
            get
            {
                return (string)GetValue(ImageProperty);
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }
        public string Description
        {
            get
            {
                return (string)GetValue(DescriptionProperty);
            }
            set
            {
                SetValue(DescriptionProperty, value);
            }
        }

        public static readonly DependencyProperty DogNameProperty;
        public static readonly DependencyProperty BreedProperty;
        public static readonly DependencyProperty ImageProperty;
        public static readonly DependencyProperty DescriptionProperty;

        static DogControl()
        {
            DogNameProperty = DependencyProperty.Register("DogName", typeof(string), typeof(DogControl),
                new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
            BreedProperty = DependencyProperty.Register("BreedProperty", typeof(string), typeof(DogControl),
                new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
            ImageProperty = DependencyProperty.Register("ImageProperty", typeof(string), typeof(DogControl),
                new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
            DescriptionProperty = DependencyProperty.Register("DescriptionProperty", typeof(string), typeof(DogControl),
                new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
        }

        public DogControl()
        {
            InitializeComponent();
            DataContext = this;
        }     
    }
}
