// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInputScopeNameFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InputScopeName))]
  [Guid(1245756242, 19415, 20052, 134, 23, 28, 218, 138, 30, 218, 127)]
  [WebHostHidden]
  internal interface IInputScopeNameFactory
  {
    InputScopeName CreateInstance(InputScopeNameValue nameValue);
  }
}
