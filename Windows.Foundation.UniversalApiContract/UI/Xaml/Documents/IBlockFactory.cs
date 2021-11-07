// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IBlockFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(118555954, 20313, 20283, 156, 229, 37, 120, 76, 67, 5, 7)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Block))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBlockFactory
  {
    Block CreateInstance(object baseInterface, out object innerInterface);
  }
}
