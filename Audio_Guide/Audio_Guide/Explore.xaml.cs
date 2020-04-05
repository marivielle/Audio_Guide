using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Audio_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Explore : ContentPage
    {
        public Explore()
        {
            InitializeComponent();
            lblClickFunc1();
            lblClickFunc2();
            lblClickFunc3();
            lblClickFunc4();
            lblClickFunc5();
            lblClickFunc6();
            lblClickFunc7();
            lblClickFunc8();
            lblClickFunc9();
            lblClickFunc10();
            lblClickFunc11();
        }
        void lblClickFunc1()
        {

            lblClick1.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc2()
        {

            lblClick2.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc3()
        {

            lblClick3.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc4()
        {

            lblClick4.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 4", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }


        void lblClickFunc5()
        {

            lblClick5.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 5", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc6()
        {

            lblClick6.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 6", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc7()
        {

            lblClick7.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 7", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc8()
        {

            lblClick8.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 8", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc9()
        {

            lblClick9.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 9", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc10()
        {

            lblClick10.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 10", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }

        void lblClickFunc11()
        {

            lblClick11.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Place 11", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad" +
                        " minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                        "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                        "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non " +
                        "proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut " +
                        "perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque " +
                        "laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et " +
                        "quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem " +
                        "quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni " +
                        "dolores eos qui ratione voluptatem sequi nesciunt.", "Back");
                })

            });
        }
        
    }
}
