// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(1179405356, 7338, 16481, 155, 64, 225, 63, 222, 21, 3, 202)]
  [ExclusiveTo(typeof (CompositionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionAnimation
  {
    void ClearAllParameters();

    void ClearParameter(string key);

    void SetColorParameter(string key, Color value);

    void SetMatrix3x2Parameter(string key, Matrix3x2 value);

    void SetMatrix4x4Parameter(string key, Matrix4x4 value);

    void SetQuaternionParameter(string key, Quaternion value);

    void SetReferenceParameter(string key, CompositionObject compositionObject);

    void SetScalarParameter(string key, float value);

    void SetVector2Parameter(string key, Vector2 value);

    void SetVector3Parameter(string key, Vector3 value);

    void SetVector4Parameter(string key, Vector4 value);
  }
}
