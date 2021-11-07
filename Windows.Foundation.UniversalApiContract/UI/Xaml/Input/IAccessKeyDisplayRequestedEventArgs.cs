// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyDisplayRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AccessKeyDisplayRequestedEventArgs))]
  [WebHostHidden]
  [Guid(201825877, 5118, 19715, 166, 29, 225, 47, 6, 86, 114, 134)]
  internal interface IAccessKeyDisplayRequestedEventArgs
  {
    string PressedKeys { get; }
  }
}
