using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data
{
    /// <summary>
    /// Menu class, hold different combination of menu items
    /// </summary>
    public static class Menu
    {
       
        /// <summary>
        /// List to hold all possible combination of treats
        /// </summary>
        //private static List<IMenuItem> _treats = new List<IMenuItem>();

        /// <summary>
        /// Contains all possible combinations of treats
        /// </summary>
        public static IEnumerable<IMenuItem> Treats
        {
            get
            {
                var _treats = new List<IMenuItem>();
                foreach (PieFilling p in Enum.GetValues(typeof(PieFilling)))
                {
                    FriedPie fp = new FriedPie();
                    fp.Flavor = p;
                    _treats.Add(fp);
                }
                foreach (IceCreamFlavor ice in Enum.GetValues(typeof(IceCreamFlavor)))
                {
                    FriedIceCream fic = new FriedIceCream();
                    fic.Flavor = ice;
                    _treats.Add(fic);
                }
                foreach (CandyBar cb in Enum.GetValues(typeof(CandyBar)))
                {
                    FriedCandyBar fcb = new FriedCandyBar();
                    fcb.CandyBar = cb;
                    _treats.Add(fcb);
                }
                FriedTwinkie ft = new FriedTwinkie();
                _treats.Add(ft);

                //_allItems.AddRange(_treats);
                return _treats;
            }
        }

        /// <summary>
        /// List to hold all possible combination of poppers
        /// </summary>
        //private static List<IMenuItem> _poppers = new List<IMenuItem>();

        /// <summary>
        /// Contains all possible combinations of Poppers
        /// </summary>
        public static IEnumerable<IMenuItem> Poppers
        {
            get
            {
                var  _poppers = new List<IMenuItem>();
                foreach (ServingSize ss in Enum.GetValues(typeof(ServingSize)))
                {
                    AppleFritters af = new AppleFritters();
                    af.Size = ss;
                    af.Glazed = true;
                    _poppers.Add(af);
                    FriedOreos fo = new FriedOreos();
                    fo.Size = ss;
                    fo.Glazed = true;
                    _poppers.Add(fo);
                    FriedCheesecake fc = new FriedCheesecake();
                    fc.Size = ss;
                    fc.Glazed = true;
                    _poppers.Add(fc);
                    FriedBananas fb = new FriedBananas();
                    fb.Size = ss;
                    fb.Glazed = true;
                    _poppers.Add(fb);
                }

                foreach (ServingSize ss in Enum.GetValues(typeof(ServingSize)))
                {
                    AppleFritters af = new AppleFritters();
                    af.Size = ss;
                    af.Glazed = false;
                    _poppers.Add(af);
                    FriedOreos fo = new FriedOreos();
                    fo.Size = ss;
                    fo.Glazed = false;
                    _poppers.Add(fo);
                    FriedCheesecake fc = new FriedCheesecake();
                    fc.Size = ss;
                    fc.Glazed = false;
                    _poppers.Add(fc);
                    FriedBananas fb = new FriedBananas();
                    fb.Size = ss;
                    fb.Glazed = false;
                    _poppers.Add(fb);
                }
                return _poppers;
            }
        }

        /// <summary>
        /// List to hold all possible combination of platters
        /// </summary>
        private static List<IMenuItem> _platters = new List<IMenuItem>();

        /// <summary>
        /// Contains all the combination of items possible in a Piper Platter or Popper Platter in the database
        /// </summary>
        public static IEnumerable<IMenuItem> Platters { 
            get {
                var _platters = new List<IMenuItem>();
                foreach (ServingSize ss in Enum.GetValues(typeof(ServingSize)))
                {
                    PopperPlatter pp = new PopperPlatter();
                    pp.Size = ss;
                    pp.Glazed = true;
                    _platters.Add(pp);
                }

                foreach (ServingSize ss in Enum.GetValues(typeof(ServingSize)))
                {
                    PopperPlatter pp = new PopperPlatter();
                    pp.Size = ss;
                    pp.Glazed = false;
                    _platters.Add(pp);
                }

                
                foreach (PieFilling lpf in Enum.GetValues(typeof(PieFilling)))
                {
                    foreach (PieFilling rpf in Enum.GetValues(typeof(PieFilling)))
                    {
                        foreach (IceCreamFlavor lice in Enum.GetValues(typeof(IceCreamFlavor)))
                        {

                            foreach (IceCreamFlavor rice in Enum.GetValues(typeof(IceCreamFlavor)))
                            {
                                PiperPlatter pip = new PiperPlatter();
                                pip.RightIceCream.Flavor = rice;
                                pip.LeftIceCream.Flavor = lice;
                                pip.RightPie.Flavor = rpf;
                                pip.LeftPie.Flavor = lpf;
                                _platters.Add(pip);

                            }
                        }
                    }
                }
                return _platters;
            } 
        }


        /// <summary>
        /// List to hold all menu items
        /// </summary>
        private static List<IMenuItem> _allItems = new List<IMenuItem>();

        /// <summary>
        /// Contains all of the items on the menu
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu { 
            get {
                /*foreach (IMenuItem item in _treats.ToList())
                {
                    _allItems.Add(item);
                }
                
                foreach (IMenuItem item2 in _poppers.ToList())
                {
                    _allItems.Add(item2);
                }*/

               
               _allItems = Treats.Concat(Poppers).Concat(Platters).ToList();
               //_allItems.AddRange(_poppers);
               //_allItems.AddRange(_platters);
               return _allItems;
            } 
        }

        /// <summary>
        /// The different types of Menu Items
        /// </summary>
        public static string[] MenuTypes
        {
            get => new string[]
            {
                "Treats",
                "Poppers",
                "Platters",
            };
        }
    }
}
