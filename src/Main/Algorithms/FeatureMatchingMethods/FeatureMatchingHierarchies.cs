using System;
using System.Data;

namespace USC.GISResearchLab.Common.Core.Geocoders.FeatureMatching
{
    public enum FeatureMatchingSelectionMethod { FeatureClassBased, UncertaintySingleFeatureArea, UncertaintyMultiFeatureGraviational, UncertaintyMultiFeatureTopological };

    public enum FeatureMatchingHierarchyOrdering { NAACCR, NAACCRReversed };

    [Serializable]
    public class FeatureMatchingHierarchies
    {

        public static DataTable GetAllFeatureMatchingSelectionMethods()
        {
            DataTable ret = new DataTable();
            ret.Columns.Add(new DataColumn("value", typeof(string)));

            foreach (FeatureMatchingSelectionMethod item in Enum.GetValues(typeof(FeatureMatchingSelectionMethod)))
            {
                DataRow row = ret.NewRow();
                row["value"] = item.ToString();
                ret.Rows.Add(row);
            }

            return ret;
        }

    }
}
