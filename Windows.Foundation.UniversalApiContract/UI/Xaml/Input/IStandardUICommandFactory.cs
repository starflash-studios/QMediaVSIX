// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IStandardUICommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2400875920, 56545, 22244, 171, 99, 245, 206, 60, 228, 235, 246)]
  [ExclusiveTo(typeof (StandardUICommand))]
  internal interface IStandardUICommandFactory
  {
    StandardUICommand CreateInstance(
      object baseInterface,
      out object innerInterface);

    StandardUICommand CreateInstanceWithKind(
      StandardUICommandKind kind,
      object baseInterface,
      out object innerInterface);
  }
}
