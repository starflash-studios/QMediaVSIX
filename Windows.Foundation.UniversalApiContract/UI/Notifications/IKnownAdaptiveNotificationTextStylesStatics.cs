// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IKnownAdaptiveNotificationTextStylesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(539071191, 35222, 17834, 139, 161, 212, 97, 215, 44, 42, 27)]
  [ExclusiveTo(typeof (KnownAdaptiveNotificationTextStyles))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IKnownAdaptiveNotificationTextStylesStatics
  {
    string Caption { get; }

    string Body { get; }

    string Base { get; }

    string Subtitle { get; }

    string Title { get; }

    string Subheader { get; }

    string Header { get; }

    string TitleNumeral { get; }

    string SubheaderNumeral { get; }

    string HeaderNumeral { get; }

    string CaptionSubtle { get; }

    string BodySubtle { get; }

    string BaseSubtle { get; }

    string SubtitleSubtle { get; }

    string TitleSubtle { get; }

    string SubheaderSubtle { get; }

    string SubheaderNumeralSubtle { get; }

    string HeaderSubtle { get; }

    string HeaderNumeralSubtle { get; }
  }
}
