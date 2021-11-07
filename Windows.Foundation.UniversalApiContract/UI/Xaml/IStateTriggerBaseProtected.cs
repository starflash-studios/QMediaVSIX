// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStateTriggerBaseProtected
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (StateTriggerBase))]
  [Guid(1010950739, 36116, 16918, 153, 76, 249, 147, 4, 41, 246, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IStateTriggerBaseProtected
  {
    void SetActive(bool IsActive);
  }
}
