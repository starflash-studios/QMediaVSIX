// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVector3TransitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(3278923417, 61083, 20700, 136, 7, 245, 29, 90, 117, 148, 149)]
  [ExclusiveTo(typeof (Vector3Transition))]
  internal interface IVector3TransitionFactory
  {
    Vector3Transition CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
