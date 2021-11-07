// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreComponentFocusable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [Guid(1392078755, 34626, 17425, 174, 105, 121, 168, 95, 41, 172, 139)]
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreComponentFocusable
  {
    bool HasFocus { get; }

    event TypedEventHandler<object, CoreWindowEventArgs> GotFocus;

    event TypedEventHandler<object, CoreWindowEventArgs> LostFocus;
  }
}
