// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IWindowingEnvironmentAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ExclusiveTo(typeof (WindowingEnvironmentAddedEventArgs))]
  [WebHostHidden]
  [Guid(4280966015, 61827, 23654, 153, 178, 66, 144, 130, 6, 146, 153)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IWindowingEnvironmentAddedEventArgs
  {
    WindowingEnvironment WindowingEnvironment { get; }
  }
}
