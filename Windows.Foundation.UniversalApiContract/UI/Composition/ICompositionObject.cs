// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(3165957445, 30217, 17744, 147, 79, 22, 0, 42, 104, 253, 237)]
  [ExclusiveTo(typeof (CompositionObject))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionObject
  {
    Compositor Compositor { get; }

    CoreDispatcher Dispatcher { get; }

    CompositionPropertySet Properties { get; }

    void StartAnimation(string propertyName, CompositionAnimation animation);

    void StopAnimation(string propertyName);
  }
}
