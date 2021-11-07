// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreInkPresenterHost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Input.Inking.Core
{
  /// <summary>Represents an object that hosts an InkPresenter without the need for an InkCanvas control.</summary>
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class CoreInkPresenterHost : ICoreInkPresenterHost
  {
    /// <summary>Initializes a new CoreInkPresenterHost object that is used to manage an InkPresenter.</summary>
    [MethodImpl]
    public extern CoreInkPresenterHost();

    /// <summary>Gets a reference to the InkPresenter associatiated with this CoreInkPresenterHost.</summary>
    /// <returns>The InkPresenter associatiated with this CoreInkPresenterHost.</returns>
    public extern InkPresenter InkPresenter { [MethodImpl] get; }

    /// <summary>Gets or sets the root visual container that the CoreInkPresenterHost draws to.</summary>
    /// <returns>A node in the composition visual tree that can have children.</returns>
    public extern ContainerVisual RootVisual { [MethodImpl] get; [MethodImpl] set; }
  }
}
