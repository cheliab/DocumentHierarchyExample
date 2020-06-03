using System;
using System.Collections.Generic;

namespace DocumentHierarchyApp
{
    public class BaseBundleDocument : BaseSaleDocument
    {
        private readonly List<String> _bundleLines;
        private readonly List<String> _deletedBundleLines;
    }
}