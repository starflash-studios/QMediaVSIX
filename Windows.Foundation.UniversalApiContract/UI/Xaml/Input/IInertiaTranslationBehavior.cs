// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInertiaTranslationBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (InertiaTranslationBehavior))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1171498258, 15154, 18562, 164, 194, 236, 250, 45, 75, 109, 240)]
  internal interface IInertiaTranslationBehavior
  {
    double DesiredDeceleration { get; set; }

    double DesiredDisplacement { get; set; }
  }
}
