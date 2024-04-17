using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace AWI_RegOrder
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the DivCom.xaml
        /// </summary>
        public string DivCom(string I_Division, string I_Company, string I_OrderType, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"DivCom.xaml", new Dictionary<string, object>{{"I_Division", I_Division}, {"I_Company", I_Company}, {"I_OrderType", I_OrderType}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return (string)result["IO_Present_URL"];
        }

        /// <summary>
        /// Invokes the AWI003_Test_Error_When_No_Quantity.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI003_Test_Error_When_No_Quantity(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI003_Test_Error_When_No_Quantity.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI021_Test_InquireBilling.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_012(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI021_Test_InquireBilling.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI002_Test_Error_For Store_on_CreditHold.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI002_Test_Error_For_Store_on_CreditHold(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI002_Test_Error_For Store_on_CreditHold.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI_RO_010.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_010(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI_RO_010.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI004_Test_Error_When_No_SellPrice.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI004_Test_Error_When_No_SellPrice(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI004_Test_Error_When_No_SellPrice.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the Framework.xaml
        /// </summary>
        public void Framework()
        {
            var result = _runWorkflowHandler(@"Framework.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the AWI019_Test_OverrideOrderMinimum.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI019_Test_OverrideOrderMinimum(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI019_Test_OverrideOrderMinimum.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI006_Test_Error When_Item_Description_Is_Missing.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI006_Test_Error_When_Item_Description_Is_Missing(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI006_Test_Error When_Item_Description_Is_Missing.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI_RO_002.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_002(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI_RO_002.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI005_Test_Error_When_Price_Override_IsGreaterThan_15Percentage.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI005_Test_Error_When_Price_Override_IsGreaterThan_15Percentage(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI005_Test_Error_When_Price_Override_IsGreaterThan_15Percentage.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI022_Test_ItemCodeFieldRestrictions.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI022_Test_ItemCodeFieldRestrictions(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI022_Test_ItemCodeFieldRestrictions.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI014_Test_ValidateSelectCancel.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI014_Test_ValidateSelectCancel(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI014_Test_ValidateSelectCancel.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI013_Test_PartialNameSearch.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI013_Test_PartialNameSearch(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI013_Test_PartialNameSearch.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI009_Test_MaximumLength.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI009_Test_MaximumLength(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI009_Test_MaximumLength.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI_RO_003.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_003(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI_RO_003.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI016_Test_DeliveryType.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_009(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI016_Test_DeliveryType.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI015_Test_ForceExtract.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI015_Test_ForceExtract(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI015_Test_ForceExtract.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI012_Test_PartialIDSearch.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI012_Test_PartialIDSearch(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI012_Test_PartialIDSearch.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI010_Test_DefaultFields.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI010_Test_DefaultFields(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI010_Test_DefaultFields.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI023_Test_ItemRelatedInfo.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI023_Test_ItemRelatedInfo(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI023_Test_ItemRelatedInfo.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI017_Test_MSITrigger.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI017_Test_MSITrigger(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI017_Test_MSITrigger.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI011_Test_MarkedNotToBill.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI011_Test_MarkedNotToBill(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI011_Test_MarkedNotToBill.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI007_Test_Switch_Home_Icon_Preferences.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI007_Test_Switch_Home_Icon_Preferences(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI007_Test_Switch_Home_Icon_Preferences.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI_RO_011.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_011(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI_RO_011.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI_RO_043.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_043(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI_RO_043.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }

        /// <summary>
        /// Invokes the AWI_RO_047.xaml
        /// </summary>
        public (string O_Output_msg, bool O_Ver_Result_Bool, string IO_Present_URL) AWI_RO_047(UiPath.Excel.CurrentRowQuickHandle I_DataRow, string IO_Present_URL)
        {
            var result = _runWorkflowHandler(@"AWI_RO_047.xaml", new Dictionary<string, object>{{"I_DataRow", I_DataRow}, {"IO_Present_URL", IO_Present_URL}}, default, default, default);
            return ((string)result["O_Output_msg"], (bool)result["O_Ver_Result_Bool"], (string)result["IO_Present_URL"]);
        }
    }
}