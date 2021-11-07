// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1740499780, 8417, 16759, 173, 68, 246, 23, 179, 116, 232, 232)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CommandBar))]
  internal interface ICommandBarFactory
  {
    CommandBar CreateInstance(object baseInterface, out object innerInterface);
  }
}
