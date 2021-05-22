#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.i18n {
    public class AppTranslations_English : AppTranslations {

        public override Lang In_Lang => TransUtil.EnAU;

        public override (string, string) In_Toolbar { get; } = (
            "QMediaVSIX In_Toolbar",
            "QMediaVSIX"
        );

        public override (string, string, string) In_CmdMediaInfo { get; } = (
            "Info",
            "(Media) Info",
            "Get info about the currently playing media."
        );

        public override (string, string, string) In_CmdSkipRev { get; } = (
            "Previous",
            "(Media) Skip Previous",
            "Previous"
        );

        public override (string, string, string) In_CmdPlayPause { get; } = (
            "Play / Pause",
            "(Media) Toggle Play Pause",
            "Play / Pause"
        );

        public override (string, string, string) In_CmdSkipFwd { get; } = (
            "Skip",
            "(Media) Skip Next",
            "Next"
        );

        public override (string, string, string) In_CmdShuffle { get; } = (
            "Toggle Shuffle",
            "(Media) Toggle Shuffle",
            "Toggle Shuffle"
        );

        public override (string, string, string) In_CmdRepeat { get; } = (
            "Toggle Repeat",
            "(Media) Toggle List Repeat",
            "Toggle List Repeat"
        );
    }
}