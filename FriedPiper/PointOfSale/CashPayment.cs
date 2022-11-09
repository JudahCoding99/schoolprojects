using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundRegister;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// ViewModel class for the Cash Payment Option
    /// </summary>
    public class CashPayment: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Used help notify the Property Changes
        /// </summary>
        /// <param name="propertyName">Name of Property that Changes</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Private backing field for the DrawerPennies property
        /// </summary>
        private uint _drawerPennies = (uint)RoundRegister.CashDrawer.Pennies;

        /// <summary>
        /// Property that represents the number of Pennies in the Drawer
        /// </summary>
        public uint DrawerPennies
        {
            get => _drawerPennies;
            set
            {
                if(_drawerPennies != value)
                {
                    RoundRegister.CashDrawer.Pennies = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerPennies)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerNickles property
        /// </summary>
        private uint _drawerNickels = (uint)RoundRegister.CashDrawer.Nickles;

        /// <summary>
        /// Property that represents the number of Nickels in the Drawer
        /// </summary>
        public uint DrawerNickles
        {
            get => _drawerNickels;
            set
            {
                if (_drawerNickels != value)
                {
                    RoundRegister.CashDrawer.Nickles = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerNickles)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerDimes property
        /// </summary>
        private uint _drawerDimes = (uint)RoundRegister.CashDrawer.Dimes;

        /// <summary>
        /// Property that represents the number of Dimes in the Drawer
        /// </summary>
        public uint DrawerDimes
        {
            get => _drawerDimes;
            set
            {
                if (_drawerDimes != value)
                {
                    RoundRegister.CashDrawer.Dimes = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerDimes)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerQuarters property
        /// </summary>
        private uint _drawerQuarters = (uint)RoundRegister.CashDrawer.Quarters;

        /// <summary>
        /// Property that represents the number of Quarters in the Drawer
        /// </summary>
        public uint DrawerQuarters
        {
            get => _drawerQuarters;
            set
            {
                if (_drawerQuarters != value)
                {
                    RoundRegister.CashDrawer.Quarters = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerQuarters)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerHalfDollarCoins property
        /// </summary>
        private uint _drawerHalfDollarCoins = (uint)RoundRegister.CashDrawer.HalfDollarCoins;

        /// <summary>
        /// Property that represents the number of Half Dollar Coins in the Drawer
        /// </summary>
        public uint DrawerHalfDollarCoins
        {
            get => _drawerHalfDollarCoins;
            set
            {
                if (_drawerHalfDollarCoins != value)
                {
                    RoundRegister.CashDrawer.HalfDollarCoins = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerHalfDollarCoins)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerDollarCoins property
        /// </summary>
        private uint _drawerDollarCoins = (uint)RoundRegister.CashDrawer.DollarCoins;

        /// <summary>
        /// Property that represents the number of Dollar coins in the Drawer
        /// </summary>
        public uint DrawerDollarCoins
        {
            get => _drawerDollarCoins;
            set
            {
                if (_drawerDollarCoins != value)
                {
                    RoundRegister.CashDrawer.DollarCoins = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerDollarCoins)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerOnes property
        /// </summary>
        private uint _drawerOnes = (uint)RoundRegister.CashDrawer.Ones;

        /// <summary>
        /// Property that represents the number of Ones in the Drawer
        /// </summary>
        public uint DrawerOnes
        {
            get => _drawerOnes;
            set
            {
                if (_drawerOnes != value)
                {
                    RoundRegister.CashDrawer.Ones = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerOnes)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerTwos property
        /// </summary>
        private uint _drawerTwos = (uint)RoundRegister.CashDrawer.Twos;

        /// <summary>
        /// Property that represents the number of Twos in the Drawer
        /// </summary>
        public uint DrawerTwos
        {
            get => _drawerTwos;
            set
            {
                if (_drawerTwos != value)
                {
                    RoundRegister.CashDrawer.Twos = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerTwos)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerFives property
        /// </summary>
        private uint _drawerFives = (uint)RoundRegister.CashDrawer.Fives;

        /// <summary>
        /// Property that represents the number of Fives in the Drawer
        /// </summary>
        public uint DrawerFives
        {
            get => _drawerFives;
            set
            {
                if (_drawerFives != value)
                {
                    RoundRegister.CashDrawer.Fives = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerFives)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerTens property
        /// </summary>
        private uint _drawerTens = (uint)RoundRegister.CashDrawer.Tens;

        /// <summary>
        /// Property that represents the number of Tens in the Drawer
        /// </summary>
        public uint DrawerTens
        {
            get => _drawerTens;
            set
            {
                if (_drawerTens != value)
                {
                    RoundRegister.CashDrawer.Tens = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerTens)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerTwenties property
        /// </summary>
        private uint _drawerTwenties = (uint)RoundRegister.CashDrawer.Twenties;

        /// <summary>
        /// Property that represents the number of Twenties in the Drawer
        /// </summary>
        public uint DrawerTwenties
        {
            get => _drawerTwenties;
            set
            {
                if (_drawerTwenties != value)
                {
                    RoundRegister.CashDrawer.Twenties = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerTwenties)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerFifties property
        /// </summary>
        private uint _drawerFifties = (uint)RoundRegister.CashDrawer.Fifties;

        /// <summary>
        /// Property that represents the number of Fifties in the Drawer
        /// </summary>
        public uint DrawerFifties
        {
            get => _drawerFifties;
            set
            {
                if (_drawerFifties != value)
                {
                    RoundRegister.CashDrawer.Fifties = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerFifties)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the DrawerHundreds property
        /// </summary>
        private uint _drawerHundreds = (uint)RoundRegister.CashDrawer.Hundreds;

        /// <summary>
        /// Property that represents the number of Hundreds in the Drawer
        /// </summary>
        public uint DrawerHundreds
        {
            get => _drawerHundreds;
            set
            {
                if (_drawerHundreds != value)
                {
                    RoundRegister.CashDrawer.Hundreds = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.DrawerHundreds)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerPennies property
        /// </summary>
        private uint _customerPennies = (uint) 0;

        /// <summary>
        /// Property that represents the number of Pennies the Customer has payed
        /// </summary>
        public uint CustomerPennies
        {
            get => _customerPennies;
            set
            {
                if (_customerPennies != value)
                {
                    _customerPennies = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerPennies)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerNickles property
        /// </summary>
        private uint _customerNickels = (uint) 0;

        /// <summary>
        /// Property that represents the number of Nickels the Customer has payed
        /// </summary>
        public uint CustomerNickles
        {
            get => _customerNickels;
            set
            {
                if (_customerNickels != value)
                {
                    _customerNickels = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerNickles)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerDimes property
        /// </summary>
        private uint _customerDimes = (uint) 0;

        /// <summary>
        /// Property that represents the number of Dimes the Customer has payed
        /// </summary>
        public uint CustomerDimes
        {
            get => _customerDimes;
            set
            {
                if (_customerDimes != value)
                {
                    _customerDimes = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerDimes)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerQuarters property
        /// </summary>
        private uint _customerQuarters = (uint) 0;

        /// <summary>
        /// Property that represents the number of Quarters the Customer has payed
        /// </summary>
        public uint CustomerQuarters
        {
            get => _customerQuarters;
            set
            {
                if (_customerQuarters != value)
                {
                    _customerQuarters = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerQuarters)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerHalfDollarCoins property
        /// </summary>
        private uint _customerHalfDollarCoins = (uint) 0;

        /// <summary>
        /// Property that represents the number of Half Dollar Coins the Customer has payed
        /// </summary>
        public uint CustomerHalfDollarCoins
        {
            get => _customerHalfDollarCoins;
            set
            {
                if (_customerHalfDollarCoins != value)
                {
                    _customerHalfDollarCoins = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerHalfDollarCoins)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerDollarCoins property
        /// </summary>
        private uint _customerDollarCoins = (uint) 0;

        /// <summary>
        /// Property that represents the number of Half Dollar Coins the Customer has payed
        /// </summary>
        public uint CustomerDollarCoins
        {
            get => _customerDollarCoins;
            set
            {
                if (_customerDollarCoins != value)
                {
                    _customerDollarCoins = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerDollarCoins)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerrOnes property
        /// </summary>
        private uint _customerOnes = (uint) 0;

        /// <summary>
        /// Property that represents the number of ones the Customer has payed
        /// </summary>
        public uint CustomerOnes
        {
            get => _customerOnes;
            set
            {
                if (_customerOnes != value)
                {
                    _customerOnes = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerOnes)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerTwos property
        /// </summary>
        private uint _customerTwos = (uint) 0;

        /// <summary>
        /// Property that represents the number of Twos the Customer has payed
        /// </summary>
        public uint CustomerTwos
        {
            get => _customerTwos;
            set
            {
                if (_customerTwos != value)
                {
                    _customerTwos = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerTwos)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerFives property
        /// </summary>
        private uint _customerFives = (uint) 0;

        /// <summary>
        /// Property that represents the number of Fives the Customer has payed
        /// </summary>
        public uint CustomerFives
        {
            get => _customerFives;
            set
            {
                if (_customerFives != value)
                {
                    _customerFives = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerFives)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerTens property
        /// </summary>
        private uint _customerTens = (uint) 0;

        /// <summary>
        /// Property that represents the number of Tens the Customer has payed
        /// </summary>
        public uint CustomerTens
        {
            get => _customerTens;
            set
            {
                if (_customerTens != value)
                {
                    _customerTens = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerTens)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerTwenties property
        /// </summary>
        private uint _customerTwenties = (uint) 0;

        /// <summary>
        /// Property that represents the number of Twenties in the Drawer
        /// </summary>
        public uint CustomerTwenties
        {
            get => _customerTwenties;
            set
            {
                if (_customerTwenties != value)
                {
                    _customerTwenties = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerTwenties)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerFifties property
        /// </summary>
        private uint _customerFifties = (uint) 0;

        /// <summary>
        /// Property that represents the number of Fifties in the Drawerr
        /// </summary>
        public uint CustomerFifties
        {
            get => _customerFifties;
            set
            {
                if (_customerFifties != value)
                {
                    _customerFifties = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerFifties)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerHundreds property
        /// </summary>
        private uint _customerHundreds = (uint) 0;

        /// <summary>
        /// Property that represents the number of Hundreds in the Drawerr
        /// </summary>
        public uint CustomerHundreds
        {
            get => _customerHundreds;
            set
            {
                if (_customerHundreds != value)
                {
                    _customerHundreds = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.CustomerHundreds)); //update Drawer Pennies to the ned value
                    OnPropertyChanged(nameof(this.CustomerPayment));
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerPennies property
        /// </summary>
        private uint _changePennies = (uint)0;

        /// <summary>
        /// Property that represents the number of Pennies the Customer has payed
        /// </summary>
        public uint ChangePennies
        {
            get => _changePennies;
            set
            {
                if (_changePennies != value)
                {
                    _changePennies = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangePennies)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerNickles property
        /// </summary>
        private uint _changeNickels = (uint)0;

        /// <summary>
        /// Property that represents the number of Nickels the Customer has payed
        /// </summary>
        public uint ChangeNickles
        {
            get => _changeNickels;
            set
            {
                if (_changeNickels != value)
                {
                    _changeNickels = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeNickles)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerDimes property
        /// </summary>
        private uint _changeDimes = (uint)0;

        /// <summary>
        /// Property that represents the number of Dimes the Customer has payed
        /// </summary>
        public uint ChangeDimes
        {
            get => _changeDimes;
            set
            {
                if (_changeDimes != value)
                {
                    _changeDimes = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeDimes)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerQuarters property
        /// </summary>
        private uint _changeQuarters = (uint)0;

        /// <summary>
        /// Property that represents the number of Quarters the Customer has payed
        /// </summary>
        public uint ChangeQuarters
        {
            get => _changeQuarters;
            set
            {
                if (_changeQuarters != value)
                {
                    _changeQuarters = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeQuarters)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerHalfDollarCoins property
        /// </summary>
        private uint _changeHalfDollarCoins = (uint)0;

        /// <summary>
        /// Property that represents the number of Half Dollar Coins the Customer has payed
        /// </summary>
        public uint ChangeHalfDollarCoins
        {
            get => _changeHalfDollarCoins;
            set
            {
                if (_changeHalfDollarCoins != value)
                {
                    _changeHalfDollarCoins = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeHalfDollarCoins)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerDollarCoins property
        /// </summary>
        private uint _changeDollarCoins = (uint)0;

        /// <summary>
        /// Property that represents the number of Half Dollar Coins the Customer has payed
        /// </summary>
        public uint ChangeDollarCoins
        {
            get => _changeDollarCoins;
            set
            {
                if (_changeDollarCoins != value)
                {
                    _changeDollarCoins = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeDollarCoins)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerrOnes property
        /// </summary>
        private uint _changeOnes = (uint)0;

        /// <summary>
        /// Property that represents the number of ones the Customer has payed
        /// </summary>
        public uint ChangeOnes
        {
            get => _changeOnes;
            set
            {
                if (_changeOnes != value)
                {
                    _changeOnes = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeOnes)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerTwos property
        /// </summary>
        private uint _changeTwos = (uint)0;

        /// <summary>
        /// Property that represents the number of Twos the Customer has payed
        /// </summary>
        public uint ChangeTwos
        {
            get => _changeTwos;
            set
            {
                if (_changeTwos != value)
                {
                    _changeTwos = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeTwos)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerFives property
        /// </summary>
        private uint _changeFives = (uint)0;

        /// <summary>
        /// Property that represents the number of Fives the Customer has payed
        /// </summary>
        public uint ChangeFives
        {
            get => _changeFives;
            set
            {
                if (_changeFives != value)
                {
                    _changeFives = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeFives)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerTens property
        /// </summary>
        private uint _changeTens = (uint)0;

        /// <summary>
        /// Property that represents the number of Tens the Customer has payed
        /// </summary>
        public uint ChangeTens
        {
            get => _changeTens;
            set
            {
                if (_changeTens != value)
                {
                    _changeTens = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeTens)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerTwenties property
        /// </summary>
        private uint _changeTwenties = (uint)0;

        /// <summary>
        /// Property that represents the number of Twenties in the Drawer
        /// </summary>
        public uint ChangeTwenties
        {
            get => _changeTwenties;
            set
            {
                if (_changeTwenties != value)
                {
                    _changeTwenties = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeTwenties)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerFifties property
        /// </summary>
        private uint _changeFifties = (uint)0;

        /// <summary>
        /// Property that represents the number of Fifties in the Drawerr
        /// </summary>
        public uint ChangeFifties
        {
            get => _changeFifties;
            set
            {
                if (_changeFifties != value)
                {
                    _changeFifties = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeFifties)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// Private backing field for the CustomerHundreds property
        /// </summary>
        private uint _changeHundreds = (uint)0;

        /// <summary>
        /// Property that represents the number of Hundreds in the Drawerr
        /// </summary>
        public uint ChangeHundreds
        {
            get => _changeHundreds;
            set
            {
                if (_changeHundreds != value)
                {
                    _changeHundreds = value; //Sets the Amount of pennies to the new value
                    OnPropertyChanged(nameof(this.ChangeHundreds)); //update Drawer Pennies to the ned value
                }
            }
        }

        /// <summary>
        /// The Total Cost of the order being processed for payment
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// How much money in different notes the customer is giving
        /// </summary>
        public decimal CustomerPaymentWithNegative
        {
            get
            {
                decimal payment = Cost - (CustomerHundreds * 100) - (CustomerFifties * 50) - (CustomerTwenties * 20) - (CustomerTens * 10) - (CustomerFives * 5) - (CustomerTwos * 2) -
                    (CustomerOnes * 1) - (CustomerDollarCoins * 1) - (CustomerHalfDollarCoins * 0.50m) - (CustomerQuarters * 0.25m) - (CustomerDimes * 0.10m) - (CustomerNickles * 0.05m) -
                    (CustomerPennies * 0.01m);
                return payment;
            }
        }

        /// <summary>
        /// How much money in different notes the customer is giving
        /// </summary>
        public decimal CustomerPayment
        {
            get
            {
                if( CustomerPaymentWithNegative < 0)
                {
                    return 0.00m;
                }
                return CustomerPaymentWithNegative;
            }
        }

        /// <summary>
        /// The change owed to 
        /// </summary>
        public decimal ChangeOwed
        {
            get
            {
                decimal changeOwed = -1 * CustomerPaymentWithNegative;
                ResetChange();
                PayBack(changeOwed);
                return (ChangePennies * 0.01m) + (ChangeNickles * 0.05m) + (ChangeDimes * 0.10m) + (ChangeQuarters * 0.25m) + (ChangeHalfDollarCoins * 0.50m) + (ChangeDollarCoins * 1) +
                    (ChangeOnes * 1) + (ChangeTwos * 1) + (ChangeFives * 5) + (ChangeTens * 10) + (ChangeTwenties * 20) + (ChangeFifties * 50) + (ChangeHundreds * 100);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        private void PayBack(decimal owed )
        {
            while(owed - 100 >= 0 && DrawerHundreds > 0) //This is my $100 loop
            {
                owed -= 100;
                DrawerHundreds--;
                ChangeHundreds++;
            }

            while (owed - 50 >= 0 && DrawerFifties > 0) //This is my $100 loop
            {
                owed -= 50;
                DrawerFifties--;
                ChangeFifties++;
            }

            while (owed - 20 >= 0 && DrawerTwenties > 0) //This is my $100 loop
            {
                owed -= 20;
                DrawerTwenties--;
                ChangeTwenties++;
            }

            while (owed - 10 >= 0 && DrawerTens > 0) //This is my $100 loop
            {
                owed -= 10;
                DrawerTens--;
                ChangeTens++;
            }

            while (owed - 5 >= 0 && DrawerFives > 0) //This is my $100 loop
            {
                owed -= 5;
                DrawerFives--;
                ChangeFives++;
            }

            while (owed - 2 >= 0 && DrawerTwos > 0) //This is my $100 loop
            {
                owed -= 2;
                DrawerTwos--;
                ChangeTwos++;
            }

            while (owed - 1 >= 0 && DrawerOnes > 0) //This is my $100 loop
            {
                owed -= 1;
                DrawerOnes--;
                ChangeOnes++;
            }

            while (owed - 1 >= 0 && DrawerDollarCoins > 0) //This is my $100 loop
            {
                owed -= 1;
                DrawerDollarCoins--;
                ChangeDollarCoins++;
            }

            while (owed - 0.50m >= 0 && DrawerHalfDollarCoins > 0) //This is my $100 loop
            {
                owed -= 0.50m;
                DrawerHalfDollarCoins--;
                ChangeHalfDollarCoins++;
            }

            while (owed - 0.25m >= 0 && DrawerQuarters > 0) //This is my $100 loop
            {
                owed -= 0.25m;
                DrawerQuarters--;
                ChangeQuarters++;
            }

            while (owed - 0.10m >= 0 && DrawerDimes > 0) //This is my $100 loop
            {
                owed -= 0.10m;
                DrawerDimes--;
                ChangeDimes++;
            }

            while (owed - 0.05m >= 0 && DrawerNickles > 0) //This is my $100 loop
            {
                owed -= 0.05m;
                DrawerNickles--;
                ChangeNickles++;
            }

            while (owed - 0.01m >= 0 && DrawerPennies > 0) //This is my $100 loop
            {
                owed -= 0.01m;
                DrawerPennies--;
                ChangePennies++;
            }

        }

        private void ResetChange()
        {

            DrawerPennies += ChangePennies;
            ChangePennies = 0; 
            DrawerNickles += ChangeNickles;
            ChangeNickles = 0;
            DrawerDimes += ChangeDimes;
            ChangeDimes = 0;
            DrawerQuarters += ChangeQuarters;
            ChangeQuarters = 0;
            DrawerHalfDollarCoins += ChangeHalfDollarCoins;
            ChangeHalfDollarCoins = 0;
            DrawerDollarCoins += ChangeDollarCoins;
            ChangeDollarCoins = 0;
            DrawerOnes += ChangeOnes;
            ChangeOnes = 0;
            DrawerTwos += ChangeTwos;
            ChangeTwos = 0;
            DrawerFives += ChangeFives;
            ChangeFives = 0;
            DrawerTens += ChangeTens;
            ChangeTens = 0;
            DrawerTwenties += ChangeTwenties;
            ChangeTwenties = 0;
            DrawerFifties += ChangeFifties;
            ChangeFifties = 0;
            DrawerHundreds += ChangeHundreds;
            ChangeHundreds = 0;

        }
    }
}

//ChangeProperties Pennies to $100
//ChangeOwed Property - The Sum of all the change owed to the customer, ResetChange method, and PayBack Method
//CustomerOwed Property - The sum of all the customer money
//