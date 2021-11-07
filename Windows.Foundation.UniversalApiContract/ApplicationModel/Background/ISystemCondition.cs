// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISystemCondition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3244274806, 35269, 16907, 171, 211, 251, 48, 48, 71, 33, 40)]
  [ExclusiveTo(typeof (SystemCondition))]
  internal interface ISystemCondition : IBackgroundCondition
  {
    SystemConditionType ConditionType { get; }
  }
}
