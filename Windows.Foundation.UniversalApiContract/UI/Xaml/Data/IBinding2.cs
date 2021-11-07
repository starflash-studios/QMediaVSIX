// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBinding2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [Guid(888762315, 1030, 18611, 158, 130, 243, 51, 236, 76, 105, 16)]
  [ExclusiveTo(typeof (Binding))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBinding2
  {
    object FallbackValue { get; set; }

    object TargetNullValue { get; set; }

    UpdateSourceTrigger UpdateSourceTrigger { get; set; }
  }
}
