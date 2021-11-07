// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IPenAndInkSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3983396918, 22280, 23612, 150, 219, 242, 245, 82, 234, 182, 65)]
  [ExclusiveTo(typeof (PenAndInkSettings))]
  internal interface IPenAndInkSettingsStatics
  {
    PenAndInkSettings GetDefault();
  }
}
