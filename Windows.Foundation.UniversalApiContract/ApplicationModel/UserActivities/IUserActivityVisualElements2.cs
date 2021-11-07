// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityVisualElements2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ExclusiveTo(typeof (UserActivityVisualElements))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3400433607, 16111, 17241, 130, 92, 157, 81, 185, 34, 13, 227)]
  internal interface IUserActivityVisualElements2
  {
    string AttributionDisplayText { get; set; }
  }
}
