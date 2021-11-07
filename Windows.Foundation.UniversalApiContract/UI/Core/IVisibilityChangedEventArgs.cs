// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IVisibilityChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [Guid(3214481642, 55297, 17764, 164, 149, 177, 232, 79, 138, 208, 133)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisibilityChangedEventArgs))]
  internal interface IVisibilityChangedEventArgs : ICoreWindowEventArgs
  {
    bool Visible { get; }
  }
}
