/* Nathan Peereboom
 * Tuesday, February 26, 2019
 * Component suggestions for McT's computer
 */


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

namespace _312840ComputerParts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCpu_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/19-117-981-V01.jpg"));
            txtComponent.Text = "I recommend the Intel Core i5-9400F as a reliable and inexpensive CPU. This 6-core 9th Gen Intel Procecer runs at a " +
                "processing speed of 2.9GHz and, with Intel Turbo Boost Technology 2.0, it can run at up to 4.1GHz. \n     I recommend this " +
                "processor because of what it has to offer in comparison to its price as well as its compatibility with the other components I " +
                "have chosen. Its 6 cores are more than enough to run the programs you use and its processing speed will help to make sure those " +
                "programs run at a good speed. Its compatibility with Intel series 300 motherboards was a big factor in my selection in this " +
                "processor. Overall, I think you will be very much pleased with this CPU. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117981";
        }

        private void btnMotherboard_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/13-157-859-V08.jpg"));
            txtComponent.Text = "The ASRock Z390M-ITX/ac is an Intel 300 series motherboard which I have recommended mostly due to its compatibility " +
                "with the other components. It supports up to 32GB of memory as well as Turbo Boost Technology 2.0. It also features 2 HDMI ports, " +
                "9 USB ports, HD audio jacks and more. It's small size of 6.7 inches by 6.7 inches will mean that it'll have no problems fitting " +
                "into your computer. I am sure that you will find this to be a realiable motherboard. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?Item=N82E16813157859&Description=Mini%20ITX&cm_re=Mini_ITX-_-13-157-859-_-Product";
        }

        private void btnMemory_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://ccimg.canadacomputers.com/Products/600x600/298/183/113680/53436.jpg"));
            txtComponent.Text = "The Corsair ValueSelect DDR4 2400MHz CL16 DIMM is a simple, inexpensive memory component that will serve your " +
                "needs. It offers 16GB of RAM and operates at a speed of 2400MHz. This model is a very popular one which comes with lifetime " +
                "warranty. I think this component is well suited for your computer. \n\nPurchase at " +
                "https://www.canadacomputers.com/product_info.php?cPath=24_311_1326&item_id=113680";
        }

        private void btnStorage_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/20-147-673-V01.jpg"));
            txtComponent.Text = "The Samsung 860 EVO Series MZ-76E1T0B/AM is an internal solid state drive with a terabyte of storage. I chose a " +
                "solid state drive as it is recommended for programs such as Visual Studio, and the lack of moving parts can help it to run faster " +
                "than a regular hard drive. I think this will be a dependable hard drive for you. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?Item=N82E16820147673";
        }

        private void btnCase_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImage/11-139-024-02.jpg"));
            txtComponent.Text = "The Corsair Obsidian Series 750D is an alluminum and steel full tower computer case with a height of 22.05 inches, " +
                "a width of 9.25 inches and a depth of 21.5 inches. This case has a lot of room inside and features 4 USB ports as well as adjacent " +
                "headphone and microphone jacks. This case allows for easy, tool-free installation of hard drive, solid state drive and optical " +
                "drive. On top of all this, 2 140 milimeter fans are included. \n     I would highly recommend this case as it is built with simple " +
                "and easy set-up in mind. The fans create minimal noise and the USB ports and audio jacks are all placed quite convieniently. I " +
                "don't think you can go wrong with this case. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?Item=N82E16811139024";
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImage/17-139-232-V08.jpg"));
            txtComponent.Text = "The Corsair RMx Series RM650x 2018 CP-9020178-NA is a full modular power supply featuring a maximum power of 650W. " +
                "One of the main appeals to this power supply is its 140mm low noise fan, which is quite silent even at its fastest speeds. This is " +
                "great choice for  apower supply if a quiet fan is important to you. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?Item=N82E16817139232&Description=Desktop%20power%20supplies&cm_re=Desktop_power_supplies-_-17-139-232-_-Product";
        }

        private void btnGraphics_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/14-137-256-V01.jpg"));
            txtComponent.Text = "While the MSI RX 570 ARMOR 8G OC graphics card is specifically built with gamers in mind, I recommend it for the " +
                "amount of video memory it offers (8GB), especially considering its relatively low price. The amount of memory is important as some " +
                "programs, such as Solidworks, require a fair amount of it. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?Item=N82E16814137256";
        }

        private void btnOptical_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("https://c1.neweggimages.com/productimage/27-136-269-08.jpg"));
            txtComponent.Text = "The LG WH16NS40 Blu-ray burner features 4MB cache as well as a BD-ROM access time of 180ms. I chose this one " +
                "because its fairly inexpensive and easy to install. \n\nPurchase at " +
                "https://www.newegg.ca/Product/Product.aspx?reviews=all&Item=N82E16827136269";
        }
    }
}
