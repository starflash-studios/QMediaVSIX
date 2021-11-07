// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.WindowServices
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWindowServicesStatics), 786432, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class WindowServices
  {
    [MethodImpl]
    public static extern IVectorView<WindowId> FindAllTopLevelWindowIds();
  }
}
