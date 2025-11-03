# Guía Rápida: Activar Claude Sonnet 4.5 en Visual Studio

## 🚀 Inicio Rápido

### Opción 1: GitHub Copilot (Más Fácil)

1. **Instalar la extensión**
   - Abre Visual Studio
   - Ve a: `Extensions` → `Manage Extensions`
   - Busca: "GitHub Copilot"
   - Instala y reinicia Visual Studio

2. **Iniciar sesión**
   - `View` → `GitHub Copilot`
   - Clic en "Sign in to GitHub"
   - Autoriza en el navegador

3. **Configurar modelo**
   - `Tools` → `Options` → `GitHub Copilot`
   - Selecciona modelo: Claude 3.5 Sonnet (si disponible)
   - Guarda cambios

### Opción 2: Visual Studio Code + Claude Dev

1. Descarga [VS Code](https://code.visualstudio.com/)
2. Instala extensión "Claude Dev" desde el marketplace
3. Configura tu API key de Anthropic en Settings

### Opción 3: API Directa de Anthropic

1. Obtén API key en [console.anthropic.com](https://console.anthropic.com/)
2. Agrega al `Web.config`:
```xml
<appSettings>
  <add key="AnthropicApiKey" value="tu-api-key" />
  <add key="ClaudeModel" value="claude-3-5-sonnet-20241022" />
</appSettings>
```

## 💡 Cómo Usar Claude

### Autocompletado
1. Escribe un comentario describiendo lo que necesitas:
   ```csharp
   // Crear método para validar datos de entrada
   ```
2. Presiona `Tab` cuando aparezca la sugerencia en gris

### Chat con Claude
1. Abre: `View` → `GitHub Copilot Chat`
2. Pregunta cualquier cosa:
   - "¿Cómo funciona este código?"
   - "Genera tests para esta clase"
   - "Optimiza este método"

### Explicar Código
1. Selecciona código
2. Clic derecho → `GitHub Copilot` → `Explain This`

## ⌨️ Atajos de Teclado

| Atajo | Acción |
|-------|--------|
| `Tab` | Aceptar sugerencia |
| `Esc` | Rechazar sugerencia |
| `Alt + ]` | Siguiente sugerencia |
| `Alt + [` | Sugerencia anterior |
| `Ctrl + /` | Toggle Copilot |

## 🛠️ Ejemplos Prácticos

### 1. Generar método
```csharp
// Método para validar formato de fecha en strings
// Claude generará el código automáticamente
```

### 2. Crear tests
```csharp
// Generar tests unitarios para la clase DataManager
// Claude creará tests completos con casos de prueba
```

### 3. Documentación
```csharp
// Agregar documentación XML a este método
public void ProcessData(string input)
{
    // Claude agregará comentarios XML
}
```

### 4. Refactorizar
Selecciona código y pregunta:
- "Refactoriza este código para usar async/await"
- "Convierte este código a LINQ"
- "Mejora el manejo de errores"

## 🔧 Solución de Problemas

### Copilot no responde
✅ Verifica conexión a Internet
✅ Reinicia Visual Studio
✅ Revisa que estés conectado a GitHub

### Sugerencias incorrectas
✅ Agrega más contexto en comentarios
✅ Guarda el archivo (Ctrl+S)
✅ Asegúrate que el tipo de archivo sea C#

### Problemas de licencia
✅ Verifica tu suscripción en GitHub
✅ Revisa estado en: github.com/settings/copilot

## 📚 Recursos

- [Documentación completa](./README.md) - Guía detallada completa
- [Configuración avanzada](./VISUAL_STUDIO_CLAUDE_SETUP.md) - Settings de VS
- [GitHub Copilot Docs](https://docs.github.com/copilot) - Documentación oficial
- [Anthropic Console](https://console.anthropic.com/) - API keys y configuración

## 🎯 Consejos

1. **Sé específico**: Describe claramente lo que necesitas
2. **Usa comentarios**: Claude entiende mejor con contexto
3. **Revisa el código**: Siempre valida lo generado
4. **Practica**: Mientras más uses Claude, mejores resultados
5. **Mantén archivos relacionados abiertos**: Ayuda a Claude con el contexto

## ❓ Preguntas Frecuentes

**P: ¿Es gratis?**
R: GitHub Copilot requiere suscripción, pero hay planes gratuitos para estudiantes y proyectos open source.

**P: ¿Funciona sin Internet?**
R: No, Claude requiere conexión a Internet para funcionar.

**P: ¿Puede Claude cometer errores?**
R: Sí, siempre revisa el código generado antes de usarlo.

**P: ¿Qué modelo es mejor?**
R: Claude 3.5 Sonnet ofrece el mejor balance entre velocidad y calidad.

**P: ¿Puedo usar Claude en otros editores?**
R: Sí, Claude está disponible en VS Code, JetBrains IDEs, y otros editores populares.

## 🔒 Privacidad y Seguridad

- No incluyas información sensible en prompts
- Revisa la configuración de privacidad en GitHub
- No compartas tu API key
- Revisa términos de servicio de GitHub/Anthropic

---

**Última actualización**: 2024-11-03

Para más ayuda, consulta la [documentación completa](./README.md) o contacta al equipo de desarrollo.
