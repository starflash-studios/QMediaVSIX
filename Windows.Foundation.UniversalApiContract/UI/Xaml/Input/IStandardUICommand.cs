// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IStandardUICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(3535765315, 1284, 21200, 138, 166, 12, 176, 247, 86, 235, 39)]
  [ExclusiveTo(typeof (StandardUICommand))]
  internal interface IStandardUICommand
  {
    StandardUICommandKind Kind { get; }
  }
}
