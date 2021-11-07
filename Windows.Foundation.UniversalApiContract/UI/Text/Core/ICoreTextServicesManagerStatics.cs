// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextServicesManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextServicesManager))]
  [Guid(354460552, 58063, 19813, 174, 185, 179, 45, 134, 254, 57, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextServicesManagerStatics
  {
    CoreTextServicesManager GetForCurrentView();
  }
}
