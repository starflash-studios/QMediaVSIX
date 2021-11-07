// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IXamlUICommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (XamlUICommand))]
  [Guid(518785219, 57441, 24080, 159, 42, 43, 170, 132, 8, 133, 194)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IXamlUICommandFactory
  {
    XamlUICommand CreateInstance(object baseInterface, out object innerInterface);
  }
}
