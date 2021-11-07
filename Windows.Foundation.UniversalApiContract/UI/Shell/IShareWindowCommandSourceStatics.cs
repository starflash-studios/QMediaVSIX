// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.IShareWindowCommandSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (ShareWindowCommandSource))]
  [Guid(2968217174, 40108, 20860, 182, 199, 142, 247, 21, 8, 66, 149)]
  internal interface IShareWindowCommandSourceStatics
  {
    ShareWindowCommandSource GetForCurrentView();
  }
}
