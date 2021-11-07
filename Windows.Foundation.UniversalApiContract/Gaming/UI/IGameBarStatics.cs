// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.IGameBarStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [Guid(498705042, 52344, 16755, 190, 69, 182, 30, 103, 40, 62, 167)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (GameBar))]
  internal interface IGameBarStatics
  {
    event EventHandler<object> VisibilityChanged;

    event EventHandler<object> IsInputRedirectedChanged;

    bool Visible { get; }

    bool IsInputRedirected { get; }
  }
}
