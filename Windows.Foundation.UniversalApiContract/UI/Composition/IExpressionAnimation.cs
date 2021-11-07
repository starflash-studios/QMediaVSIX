// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IExpressionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ExpressionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1791775793, 32061, 19443, 171, 182, 244, 75, 220, 72, 136, 193)]
  internal interface IExpressionAnimation
  {
    string Expression { get; set; }
  }
}
