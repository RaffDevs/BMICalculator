# BMICalculator

<img width="372" height="752" alt="image" src="https://github.com/user-attachments/assets/091b5011-9dbb-475a-bfef-cba4a77ae67e" />

**Visao Geral**
Projeto em .NET MAUI que organiza um calculo de IMC (Indice de Massa Corporal) usando o padrao MVVM. O ViewModel recebe altura (cm) e peso (kg) e expõe o resultado do IMC para binding na interface.

**Funcionalidades**
- Calculo de IMC a partir
 de altura e peso.
- Estrutura MVVM com `CommunityToolkit.Mvvm`.
- Paginas XAML de exemplo para layout.

**Tecnologias**
- .NET MAUI
- C#
- XAML
- CommunityToolkit.Mvvm
- CommunityToolkit.Maui
- Syncfusion.Maui.Gauges

**Estrutura do Projeto**
- `MVVM/Models/BMI.cs`: modelo com calculo do IMC.
- `MVVM/ViewModels/BMIViewModel.cs`: ViewModel com propriedades observaveis.
- `MainPage.xaml`: pagina inicial (template padrao do MAUI).
- `Pages/SegundaView.xaml`: pagina de exemplo com Grid.

**Como Executar**
1. Instale o .NET SDK e a workload do MAUI.
2. Restaure os pacotes e compile:

```bash
dotnet build
```

3. Para rodar no iOS (macOS com Xcode configurado):

```bash
dotnet build -t:Run -f net10.0-ios
```

**Observacoes**
- O alvo atual do projeto e iOS (`net10.0-ios`). Ajuste o `TargetFramework` no `BMICalculator.csproj` se quiser compilar para outras plataformas.

**Licenca**
- Ainda nao definida.
