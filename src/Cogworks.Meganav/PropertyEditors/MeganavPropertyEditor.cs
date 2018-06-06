﻿using Umbraco.Core.PropertyEditors;

namespace Cogworks.Meganav.PropertyEditors
{
    [PropertyEditor(Constants.PropertyEditorAlias, Constants.PackageName, Constants.PackageFilesPath + "views/editor.html", ValueType = "JSON", Group = "pickers", Icon = "icon-sitemap")]
    public class MeganavPropertyEditor : PropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new MeganavPreValueEditor();
        }

        internal class MeganavPreValueEditor : PreValueEditor
        {
            [PreValueField("maxDepth", "Max depth", "number", Description = "The maximum number of levels in the navigation")]
            public string MaxDepth { get; set; }
            
            [PreValueField("removeNaviHideItems", "Remove hidden items", "boolean", Description = "Remove items where umbracoNaviHide is true")]
            public bool RemoveNaviHideItems { get; set; }
        }
    }
}