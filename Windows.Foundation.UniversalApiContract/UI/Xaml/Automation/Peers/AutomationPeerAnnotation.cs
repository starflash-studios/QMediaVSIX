// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Represents a single UI automation annotation.</summary>
  [Activatable(typeof (IAutomationPeerAnnotationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPeerAnnotationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AutomationPeerAnnotation : DependencyObject, IAutomationPeerAnnotation
  {
    /// <summary>Initializes a new instance of the  class using the defined parameter.</summary>
    /// <param name="type">The type of annotation.</param>
    [MethodImpl]
    public extern AutomationPeerAnnotation(AnnotationType type);

    /// <summary>Initializes a new instance of the  class using the defined parameters.</summary>
    /// <param name="type">The type of annotation.</param>
    /// <param name="peer">The automation peer of the element that implements the annotation.</param>
    [MethodImpl]
    public extern AutomationPeerAnnotation(AnnotationType type, AutomationPeer peer);

    /// <summary>Initializes a new instance of the  class.</summary>
    [MethodImpl]
    public extern AutomationPeerAnnotation();

    /// <summary>Gets or sets the type of the annotation.</summary>
    /// <returns>The type of the annotation.</returns>
    public extern AnnotationType Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the automation peer of the element that implements the annotation.</summary>
    /// <returns>The automation peer of the element that implements the annotation.</returns>
    public extern AutomationPeer Peer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the AutomationPeerAnnotation.Type property.</summary>
    /// <returns>The AutomationPeerAnnotation.Type property.</returns>
    public static extern DependencyProperty TypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutomationPeerAnnotation.Peer property.</summary>
    /// <returns>The AutomationPeerAnnotation.Peer property.</returns>
    public static extern DependencyProperty PeerProperty { [MethodImpl] get; }
  }
}
