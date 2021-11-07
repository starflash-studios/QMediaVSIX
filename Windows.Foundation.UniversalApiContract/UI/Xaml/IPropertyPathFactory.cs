// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyPathFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PropertyPath))]
  [WebHostHidden]
  [Guid(1313660825, 38950, 20054, 132, 124, 202, 5, 95, 22, 41, 5)]
  internal interface IPropertyPathFactory
  {
    PropertyPath CreateInstance(string path);
  }
}
