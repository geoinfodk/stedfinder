﻿using System.Collections;

namespace PlaceFinder.Interface
{
    public interface IPlaceFinderController
    {
        void SearchTextChange(string searchString);
        void ZoomTo(string selectedAddress);
        void SearchResourcesChange(IEnumerable checkedItemCollection);
    }
}