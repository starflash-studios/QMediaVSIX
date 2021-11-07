// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVector3Transition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3538029020, 50338, 20737, 154, 104, 250, 1, 80, 80, 85, 137)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (Vector3Transition))]
  internal interface IVector3Transition
  {
    TimeSpan Duration { get; set; }

    Vector3TransitionComponents Components { get; set; }
  }
}
