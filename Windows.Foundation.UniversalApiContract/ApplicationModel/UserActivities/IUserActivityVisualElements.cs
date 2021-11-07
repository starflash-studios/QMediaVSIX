// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityVisualElements
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Shell;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(2490725651, 9775, 18927, 187, 191, 155, 117, 210, 232, 82, 80)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (UserActivityVisualElements))]
  internal interface IUserActivityVisualElements
  {
    string DisplayText { get; set; }

    string Description { get; set; }

    Color BackgroundColor { get; set; }

    UserActivityAttribution Attribution { get; set; }

    IAdaptiveCard Content { set; get; }
  }
}
