using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tthk_CarouselPage
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button btn = new Button
            {
                Text = "Корпуса"
            };
            Button btn1 = new Button
            {
                Text = "Материнские Платы"
            };
            Button btn2 = new Button
            {
                Text = "Видеокарты"
            };
            Button btn3 = new Button
            {
                Text = "Процессоры"
            };
            Button btn4 = new Button
            {
                Text = "ОЗУ"
            };
            Button btn5 = new Button
            {
                Text = "HDD"
            };

            Label gpuL = new Label
            {
                Text = "Видеокарта",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image gpuI = new Image
            {
                Source = "gpu.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label caseL = new Label
            {
                Text = "Корпуса",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image caseI = new Image
            {
                Source = "pccase.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label moboL = new Label
            {
                Text = "Материнские Платы",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image moboI = new Image
            {
                Source = "mobo.png",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label cpuL = new Label
            {
                Text = "Процессоры",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image cpuI = new Image
            {
                Source = "cpu.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label ramL = new Label
            {
                Text = "ОЗУ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image ramI = new Image
            {
                Source = "ram.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label hddL = new Label
            {
                Text = "HDD",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image hddI = new Image
            {
                Source = "hdd.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };




            var tapImage = new TapGestureRecognizer();
            var tapImage1 = new TapGestureRecognizer();
            var tapImage2 = new TapGestureRecognizer();
            var tapImage3 = new TapGestureRecognizer();
            var tapImage4 = new TapGestureRecognizer();
            var tapImage5 = new TapGestureRecognizer();

               
            caseI.GestureRecognizers.Add(tapImage);
            moboI.GestureRecognizers.Add(tapImage1);
            gpuI.GestureRecognizers.Add(tapImage2);
            cpuI.GestureRecognizers.Add(tapImage3);
            ramI.GestureRecognizers.Add(tapImage4);
            hddI.GestureRecognizers.Add(tapImage5);

            tapImage.Tapped += tapImage_Tapped;
            tapImage1.Tapped += tapImage1_Tapped;
            tapImage2.Tapped += tapImage2_Tapped;
            tapImage3.Tapped += tapImage3_Tapped;
            tapImage4.Tapped += tapImage4_Tapped;
            tapImage5.Tapped += tapImage5_Tapped;

            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;

            var Case = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        caseL,
                        caseI,
                        btn 
                    }

                }
            };
            var mobo = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        moboL,
                        moboI,
                        btn1 
                    }

                }
            };
            var gpu = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        gpuL,
                        gpuI,
                        btn2 
                    }

                }
            };
            var cpu = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        cpuL,
                        cpuI,
                        btn3
                    }

                }
            };
            var ram = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        ramL,
                        ramI,
                        btn4
                    }
                }
            };
            var HDD = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        hddL,
                        hddI,
                        btn5
                    }

                }
            };
            Children.Add(Case);
            Children.Add(mobo);
            Children.Add(gpu);
            Children.Add(cpu);
            Children.Add(ram);
            Children.Add(HDD);
        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=hdd");
            await Browser.OpenAsync(uri);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%BE%D0%BF%D0%B5%D1%80%D0%B0%D1%82%D0%B8%D0%B2%D0%BD%D0%B0%D1%8F+%D0%BF%D0%B0%D0%BC%D1%8F%D1%82%D1%8C");
            await Browser.OpenAsync(uri);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%BF%D1%80%D0%BE%D1%86%D0%B5%D1%81%D1%81%D0%BE%D1%80%D1%8B");
            await Browser.OpenAsync(uri);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%B2%D0%B8%D0%B4%D0%B5%D0%BE%D0%BA%D0%B0%D1%80%D1%82%D1%8B");
            await Browser.OpenAsync(uri);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%BC%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%BD%D1%81%D0%BA%D0%B8%D0%B5+%D0%BF%D0%BB%D0%B0%D1%82%D1%8B");
            await Browser.OpenAsync(uri);
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=korpused");
            await Browser.OpenAsync(uri);
        }
        void tapImage_Tapped(object sender, EventArgs e)
        {    
            DisplayAlert("Корпус", "Корпус ПК является важным элементом, на котором крепятся все его устройства и защищающий их от воздействия окружающей среды.", "OK");
        } 
        void tapImage1_Tapped(object sender, EventArgs e)
        {    
            DisplayAlert("Материнская Плата", "Материнская плата — печатная плата, являющаяся основой построения модульного устройства, например — компьютера.", "OK");
        }
        void tapImage2_Tapped(object sender, EventArgs e)
        {  
             DisplayAlert("Видеокарта", "Видеокарта – устройство, преобразующее графический образ, хранящийся как содержимое памяти компьютера, в форму, пригодную для дальнейшего вывода на экран монитора.", "OK");
        }
        void tapImage3_Tapped(object sender, EventArgs e)
        {  
             DisplayAlert("Процессор", "Центральный процессор — электронный блок либо интегральная схема, исполняющая машинные инструкции, главная часть аппаратного обеспечения компьютера или программируемого логического контроллера.", "OK");
        }
        void tapImage4_Tapped(object sender, EventArgs e)
        {  
             DisplayAlert("ОЗУ", "Оперативная память или операти́вное запомина́ющее устро́йство — энергозависимая часть системы компьютерной памяти, в которой во время работы компьютера хранится выполняемый машинный код, а также входные, выходные и промежуточные данные, обрабатываемые процессором.", "OK");
        }
        void tapImage5_Tapped(object sender, EventArgs e)
        {  
             DisplayAlert("HDD", "Жёсткий диск — запоминающее устройство произвольного доступа, основанное на принципе магнитной записи. Является основным накопителем данных в большинстве компьютеров.", "OK");
        }
    }
};