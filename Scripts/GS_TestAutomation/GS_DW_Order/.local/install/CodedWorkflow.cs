using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace GS_TestAutomation
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace GS_TestAutomation.ObjectRepository
{
    public static class Descriptors
    {
        public static class CnS_Cloud_IO
        {
            public static _Implementation._CnS_Cloud_IO.__GS_Regular_Order_Screen GS_Regular_Order_Screen { get; private set; } = new _Implementation._CnS_Cloud_IO.__GS_Regular_Order_Screen();
            public static _Implementation._CnS_Cloud_IO.__GS_Rush_Order_Screen GS_Rush_Order_Screen { get; private set; } = new _Implementation._CnS_Cloud_IO.__GS_Rush_Order_Screen();
            public static _Implementation._CnS_Cloud_IO.__Home_Screen Home_Screen { get; private set; } = new _Implementation._CnS_Cloud_IO.__Home_Screen();
            public static _Implementation._CnS_Cloud_IO.__LoginPage LoginPage { get; private set; } = new _Implementation._CnS_Cloud_IO.__LoginPage();
        }
    }
}

namespace GS_TestAutomation._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class ___Item_Code_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Item_Code_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/Km9I0snUZEOBk0wsqGxkUA", DisplayName = "'Item Code'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class ___Qty_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Qty_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/4_feYCme3kSyKgbiPibWhw", DisplayName = "'Qty'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class ___Sell__Cloumn : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Sell__Cloumn(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/xUj8I26LfUO3WjfUqGyZQw", DisplayName = "'Sell' Cloumn", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Customer : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Customer(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/BTiLHUhh1EGNgEIAffbA1A", DisplayName = "Customer", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Cycle : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Cycle(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/UhW0kaEbP0mXX6S23r060g", DisplayName = "Cycle", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Description : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Description(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/EA_4ylwdpUC98CnwpQj93Q", DisplayName = "Description", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Error_Indication : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Error_Indication(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/5_Q2ZWDDEE-0o9rMI6Y0Lg", DisplayName = "Error Indication", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Order_Entry_Screen_Text : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Order_Entry_Screen_Text(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/rhCofuBRn0eXt6V-ASZMiQ", DisplayName = "Order Entry Screen Text", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Regular_Order_Popups : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Regular_Order_Popups(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/UsxIjbJMpEO_0cRq5u4AhA", DisplayName = "Regular Order Popups", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Regular_Order_Screen
    {
        public class __Submit_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/IH7Ba4I0N0SvDOlkTN79GQ", DisplayName = "Submit Button", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO
    {
        public class __GS_Regular_Order_Screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __GS_Regular_Order_Screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/Akxxs_siZEOo0if5vbHkeg", DisplayName = "GS Regular Order Screen", Screen = this};
                _Item_Code_ = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.___Item_Code_(this, null);
                _Qty_ = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.___Qty_(this, null);
                _Sell__Cloumn = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.___Sell__Cloumn(this, null);
                Customer = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Customer(this, null);
                Cycle = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Cycle(this, null);
                Description = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Description(this, null);
                Error_Indication = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Error_Indication(this, null);
                Order_Entry_Screen_Text = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Order_Entry_Screen_Text(this, null);
                Regular_Order_Popups = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Regular_Order_Popups(this, null);
                Submit_Button = new _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Submit_Button(this, null);
            }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.___Item_Code_ _Item_Code_ { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.___Qty_ _Qty_ { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.___Sell__Cloumn _Sell__Cloumn { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Customer Customer { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Cycle Cycle { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Description Description { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Error_Indication Error_Indication { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Order_Entry_Screen_Text Order_Entry_Screen_Text { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Regular_Order_Popups Regular_Order_Popups { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Regular_Order_Screen.__Submit_Button Submit_Button { get; private set; }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class ___Close__Button_for_Error_Popups : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Close__Button_for_Error_Popups(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/K3Z8o-g1Z0GPQPaEFg2Znw", DisplayName = "'Close' Button for Error Popups", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class ___Close__For_Success : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Close__For_Success(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/w_Lrv27JKUyUsrNhEfQpKQ", DisplayName = "'Close' For Success", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class ___Sell__Column : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Sell__Column(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/oaoV1Zl-mUmtz39QahHiFw", DisplayName = "'Sell' Column", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Credit_hold_popup_No_button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Credit_hold_popup_No_button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/OZoCv3vTtk6gbOOlwlWXTw", DisplayName = "Credit hold popup No button", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Description : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Description(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/9rylt7CmDUqlbZF93-zXmA", DisplayName = "Description", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Internal_toggle : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Internal_toggle(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/9VPKOMmAP0erlJY3G6ASkg", DisplayName = "Internal toggle", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Item_Code : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Item_Code(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/3lFRYXGiLkuSKr-zR0ko8Q", DisplayName = "Item Code", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __PO___Feild : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __PO___Feild(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/lSTNtvA2UUq2ECALhym_Jg", DisplayName = "PO # Feild", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Qty : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Qty(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/L1SCFkLFuEKekiicDkWzmQ", DisplayName = "Qty", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Qty_Error_popup_Text : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Qty_Error_popup_Text(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/SswJusn7VkWFAcMuu7NK9Q", DisplayName = "Qty Error popup Text", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Route__pencil_symbol : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Route__pencil_symbol(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/oyk3AZc1WEKyCtjCwxmAbw", DisplayName = "Route  pencil symbol", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Route__feild : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Route__feild(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/yrXuSmchz06Ol3SNJBHZOg", DisplayName = "Route# feild", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __RuO_Apply_button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __RuO_Apply_button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/ecC0TEwalEqI2Bnt6b7wfw", DisplayName = "RuO Apply button", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Rush_Order_Popups : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Rush_Order_Popups(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/1PLbofAziE-o4BDxukR0UQ", DisplayName = "Rush Order Popups", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._GS_Rush_Order_Screen
    {
        public class __Sell_Warning_popup : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sell_Warning_popup(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/h7qUbcxf2U6uxVyQyGld_g", DisplayName = "Sell Warning popup", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO
    {
        public class __GS_Rush_Order_Screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __GS_Rush_Order_Screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/9sQt2lb7r0i8Z3lp8IutSg", DisplayName = "GS Rush Order Screen", Screen = this};
                _Close__Button_for_Error_Popups = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.___Close__Button_for_Error_Popups(this, null);
                _Close__For_Success = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.___Close__For_Success(this, null);
                _Sell__Column = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.___Sell__Column(this, null);
                Credit_hold_popup_No_button = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Credit_hold_popup_No_button(this, null);
                Description = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Description(this, null);
                Internal_toggle = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Internal_toggle(this, null);
                Item_Code = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Item_Code(this, null);
                PO___Feild = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__PO___Feild(this, null);
                Qty = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Qty(this, null);
                Qty_Error_popup_Text = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Qty_Error_popup_Text(this, null);
                Route__pencil_symbol = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Route__pencil_symbol(this, null);
                Route__feild = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Route__feild(this, null);
                RuO_Apply_button = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__RuO_Apply_button(this, null);
                Rush_Order_Popups = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Rush_Order_Popups(this, null);
                Sell_Warning_popup = new _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Sell_Warning_popup(this, null);
            }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.___Close__Button_for_Error_Popups _Close__Button_for_Error_Popups { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.___Close__For_Success _Close__For_Success { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.___Sell__Column _Sell__Column { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Credit_hold_popup_No_button Credit_hold_popup_No_button { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Description Description { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Internal_toggle Internal_toggle { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Item_Code Item_Code { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__PO___Feild PO___Feild { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Qty Qty { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Qty_Error_popup_Text Qty_Error_popup_Text { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Route__pencil_symbol Route__pencil_symbol { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Route__feild Route__feild { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__RuO_Apply_button RuO_Apply_button { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Rush_Order_Popups Rush_Order_Popups { get; private set; }

            public _Implementation._CnS_Cloud_IO._GS_Rush_Order_Screen.__Sell_Warning_popup Sell_Warning_popup { get; private set; }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Company_Code : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Company_Code(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/kR9kq_G370OPJptyNaD0ZA", DisplayName = "Company Code", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Confirm_to_Leave_the_Page : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Confirm_to_Leave_the_Page(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/TQAhu27hOk-l-Klo2esvow", DisplayName = "Confirm to Leave the Page", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Division : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Division(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/RpBBVnRTU0qE6iQR7xRwhw", DisplayName = "Division", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Get_Text__Switch_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Get_Text__Switch_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/DcpE-VshaEikLkZsGUPmVQ", DisplayName = "Get Text 'Switch'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __GS_Order_Management : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __GS_Order_Management(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/9xGjmXQomkS1CGwZbPqazA", DisplayName = "GS Order Management", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Home : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Home(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/ZX8WtMV3OU6i7UY7oXg8cQ", DisplayName = "Home", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Home_Company_element : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Home_Company_element(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/2rfnAuIrDUCKNKH4mMAsSg", DisplayName = "Home Company element", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Home_Division_Element : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Home_Division_Element(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/Ctbd15YgBUaOkOQ4F_avKg", DisplayName = "Home Division Element", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Item_Type : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Item_Type(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/UPh3pCMcoEKGRaLvQ3oIYQ", DisplayName = "Item Type", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Loding : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loding(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/cedZd4vhBEykm2niNcRhSQ", DisplayName = "Loding", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __New_Order_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Order_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/v8F3wzPSxkCfXXSYtSLhQg", DisplayName = "New Order Button", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Order_Successful_Popop : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Order_Successful_Popop(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/PFUS3KPbA0mCGJ5kYE4Yvw", DisplayName = "Order Successful Popop", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Order_Type : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Order_Type(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/MH96VLpE1UWkOWJjxtqIsw", DisplayName = "Order Type", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Popup : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Popup(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/EEYroSQFh0mO_gNPJpxW6w", DisplayName = "Popup", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Popup_Message_Text : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Popup_Message_Text(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/kDJNNKNhjUiskiSJ3ZpOKg", DisplayName = "Popup Message Text", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Profile_Logo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Profile_Logo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/3DefwU39L0qrQLCvfwvzXg", DisplayName = "Profile Logo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __RushOrder_CheckBox : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __RushOrder_CheckBox(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/569fAKzxF0a1oNraGzaLTA", DisplayName = "RushOrder CheckBox", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Sign_Out : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sign_Out(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/NpKuXhcnw0Cz5azajMBngQ", DisplayName = "Sign Out", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Simple_Order_Entry : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Simple_Order_Entry(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/lmk5p_4aoE2Me71qmAFa8g", DisplayName = "Simple Order Entry", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Switch_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Switch_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/Y1pbFnMYs0K1BTKbvzlheA", DisplayName = "Switch Button", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Switch_Element : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Switch_Element(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/cQdS1G-FMU2UTBqJn9iyyw", DisplayName = "Switch Element", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Type_Into__Customer_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Type_Into__Customer_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/RI9m5-QozUC-b3iuQffbuA", DisplayName = "Type Into 'Customer'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO._Home_Screen
    {
        public class __Type_Into__Qty_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Type_Into__Qty_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/KpE6NKcp_UyODW0x7ZFfug", DisplayName = "Type Into 'Qty'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO
    {
        public class __Home_Screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Home_Screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/mk05m9gukkGdiOOV2fXmKg", DisplayName = "Home Screen", Screen = this};
                Company_Code = new _Implementation._CnS_Cloud_IO._Home_Screen.__Company_Code(this, null);
                Confirm_to_Leave_the_Page = new _Implementation._CnS_Cloud_IO._Home_Screen.__Confirm_to_Leave_the_Page(this, null);
                Division = new _Implementation._CnS_Cloud_IO._Home_Screen.__Division(this, null);
                Get_Text__Switch_ = new _Implementation._CnS_Cloud_IO._Home_Screen.__Get_Text__Switch_(this, null);
                GS_Order_Management = new _Implementation._CnS_Cloud_IO._Home_Screen.__GS_Order_Management(this, null);
                Home = new _Implementation._CnS_Cloud_IO._Home_Screen.__Home(this, null);
                Home_Company_element = new _Implementation._CnS_Cloud_IO._Home_Screen.__Home_Company_element(this, null);
                Home_Division_Element = new _Implementation._CnS_Cloud_IO._Home_Screen.__Home_Division_Element(this, null);
                Item_Type = new _Implementation._CnS_Cloud_IO._Home_Screen.__Item_Type(this, null);
                Loding = new _Implementation._CnS_Cloud_IO._Home_Screen.__Loding(this, null);
                New_Order_Button = new _Implementation._CnS_Cloud_IO._Home_Screen.__New_Order_Button(this, null);
                Order_Successful_Popop = new _Implementation._CnS_Cloud_IO._Home_Screen.__Order_Successful_Popop(this, null);
                Order_Type = new _Implementation._CnS_Cloud_IO._Home_Screen.__Order_Type(this, null);
                Popup = new _Implementation._CnS_Cloud_IO._Home_Screen.__Popup(this, null);
                Popup_Message_Text = new _Implementation._CnS_Cloud_IO._Home_Screen.__Popup_Message_Text(this, null);
                Profile_Logo = new _Implementation._CnS_Cloud_IO._Home_Screen.__Profile_Logo(this, null);
                RushOrder_CheckBox = new _Implementation._CnS_Cloud_IO._Home_Screen.__RushOrder_CheckBox(this, null);
                Sign_Out = new _Implementation._CnS_Cloud_IO._Home_Screen.__Sign_Out(this, null);
                Simple_Order_Entry = new _Implementation._CnS_Cloud_IO._Home_Screen.__Simple_Order_Entry(this, null);
                Switch_Button = new _Implementation._CnS_Cloud_IO._Home_Screen.__Switch_Button(this, null);
                Switch_Element = new _Implementation._CnS_Cloud_IO._Home_Screen.__Switch_Element(this, null);
                Type_Into__Customer_ = new _Implementation._CnS_Cloud_IO._Home_Screen.__Type_Into__Customer_(this, null);
                Type_Into__Qty_ = new _Implementation._CnS_Cloud_IO._Home_Screen.__Type_Into__Qty_(this, null);
            }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Company_Code Company_Code { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Confirm_to_Leave_the_Page Confirm_to_Leave_the_Page { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Division Division { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Get_Text__Switch_ Get_Text__Switch_ { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__GS_Order_Management GS_Order_Management { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Home Home { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Home_Company_element Home_Company_element { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Home_Division_Element Home_Division_Element { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Item_Type Item_Type { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Loding Loding { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__New_Order_Button New_Order_Button { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Order_Successful_Popop Order_Successful_Popop { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Order_Type Order_Type { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Popup Popup { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Popup_Message_Text Popup_Message_Text { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Profile_Logo Profile_Logo { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__RushOrder_CheckBox RushOrder_CheckBox { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Sign_Out Sign_Out { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Simple_Order_Entry Simple_Order_Entry { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Switch_Button Switch_Button { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Switch_Element Switch_Element { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Type_Into__Customer_ Type_Into__Customer_ { get; private set; }

            public _Implementation._CnS_Cloud_IO._Home_Screen.__Type_Into__Qty_ Type_Into__Qty_ { get; private set; }
        }
    }

    namespace _CnS_Cloud_IO._LoginPage
    {
        public class __UserName : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __UserName(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/oyaW1JcHw0Kw3o5C2FdyCw", DisplayName = "UserName", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CnS_Cloud_IO
    {
        public class __LoginPage : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __LoginPage()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "D9F-caV3OUejNlJ30AZkgg/xONbwc9vz0epw7aYlpGCiA", DisplayName = "LoginPage", Screen = this};
                UserName = new _Implementation._CnS_Cloud_IO._LoginPage.__UserName(this, null);
            }

            public _Implementation._CnS_Cloud_IO._LoginPage.__UserName UserName { get; private set; }
        }
    }
}