#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System;
using System.Collections.Generic;
using System.Reflection;

#endregion

namespace QMediaVSIX.i18n {
    public abstract class AppTranslations {
        // ReSharper disable once EmptyConstructor //Ensures inherited classes must have an empty constructor
        protected AppTranslations() { }

        public static (string ButtonText, string CommandSet) Toolbar => AppTranslations_Helper.UITrans.In_Toolbar;
        public static (string ButtonText, string CommandName, string TooltipText) CmdMediaInfo => AppTranslations_Helper.UITrans.In_CmdMediaInfo;
        public static (string ButtonText, string CommandName, string TooltipText) CmdSkipRev => AppTranslations_Helper.UITrans.In_CmdSkipRev;
        public static (string ButtonText, string CommandName, string TooltipText) CmdPlayPause => AppTranslations_Helper.UITrans.In_CmdPlayPause;
        public static (string ButtonText, string CommandName, string TooltipText) CmdSkipFwd => AppTranslations_Helper.UITrans.In_CmdSkipFwd;
        public static (string ButtonText, string CommandName, string TooltipText) CmdShuffle => AppTranslations_Helper.UITrans.In_CmdShuffle;
        public static (string ButtonText, string CommandName, string TooltipText) CmdRepeat => AppTranslations_Helper.UITrans.In_CmdRepeat;
        public static (string ButtonText, string CommandName, string TooltipText) CmdVolume => AppTranslations_Helper.UITrans.In_CmdVolume;


        public abstract Lang In_Lang { get; }
        public abstract (string ButtonText, string CommandSet) In_Toolbar { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdMediaInfo { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdSkipRev { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdPlayPause { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdSkipFwd { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdShuffle { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdRepeat { get; }
        public abstract (string ButtonText, string CommandName, string TooltipText) In_CmdVolume { get; }
    }

    public static class AppTranslations_Helper {
        public static Dictionary<Lang, AppTranslations> AllTrans;
        public static AppTranslations UITrans, Trans;

        static AppTranslations_Helper() {
            AllTrans = new Dictionary<Lang, AppTranslations>();
            Type AppT = typeof(AppTranslations);
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach(Type T in Assembly.GetExecutingAssembly().GetTypes()) {
                if (T != null && AppT.IsAssignableFrom(T) && AppT != T) {
                    AppTranslations Obj = T.GetConstructor(Type.EmptyTypes).Invoke(null) as AppTranslations;
                    AllTrans.Add(Obj.In_Lang, Obj);
                }
            }

            bool FoundUI = false, Found = false;
            // ReSharper disable ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            foreach(KeyValuePair<Lang, AppTranslations> AT in AllTrans) {
                if (!FoundUI && TransUtil.CurrentUI.IsSameTag(AT.Key)) {
                    UITrans = AT.Value;
                    FoundUI = true;
                }
                if (!Found && TransUtil.Current.IsSameTag(AT.Key)) {
                    Trans = AT.Value;
                    Found = true;
                }
            }
            foreach (KeyValuePair<Lang, AppTranslations> AT in AllTrans) {
                if (!FoundUI && TransUtil.CurrentUI.IsSameFamily(AT.Key, false)) {
                    UITrans = AT.Value;
                    FoundUI = true;
                }
                if (!Found && TransUtil.Current.IsSameFamily(AT.Key, false)) {
                    Trans = AT.Value;
                    Found = true;
                }
            }
            foreach (KeyValuePair<Lang, AppTranslations> AT in AllTrans) {
                if (!FoundUI && TransUtil.CurrentUI.SharesVariance(AT.Key)) {
                    UITrans = AT.Value;
                    FoundUI = true;
                }
                if (!Found && TransUtil.Current.SharesVariance(AT.Key)) {
                    Trans = AT.Value;
                    Found = true;
                }
            }
            foreach (KeyValuePair<Lang, AppTranslations> AT in AllTrans) {
                if (!FoundUI && TransUtil.CurrentUI.SharesLooseRelation(AT.Key)) {
                    UITrans = AT.Value;
                    FoundUI = true;
                }
                if (!Found && TransUtil.Current.SharesLooseRelation(AT.Key)) {
                    Trans = AT.Value;
                    Found = true;
                }
            }
            // ReSharper restore ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator

            if (!FoundUI) { UITrans = Found ? Trans : new AppTranslations_English(); }
            if (!Found) { Trans = FoundUI ? UITrans : new AppTranslations_English(); }
        }
    }
}
