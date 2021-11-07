// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ISystemNavigationManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(3696408014, 48864, 17157, 140, 84, 104, 34, 142, 214, 131, 181)]
  [ExclusiveTo(typeof (SystemNavigationManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemNavigationManagerStatics
  {
    SystemNavigationManager GetForCurrentView();
  }
}
