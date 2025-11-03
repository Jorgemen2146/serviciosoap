# Visual Studio Settings for Claude Sonnet Integration

## GitHub Copilot Configuration

### Accessing GitHub Copilot Settings in Visual Studio

1. **Tools** → **Options** → **GitHub Copilot**
2. Enable the following options:
   - ☑ Enable GitHub Copilot
   - ☑ Enable inline suggestions
   - ☑ Show suggestions automatically

### Keyboard Shortcuts

Configure these shortcuts for better Claude/Copilot integration:

**Tools** → **Options** → **Environment** → **Keyboard**

Recommended shortcuts:
- `Edit.ToggleCompletionMode` → `Ctrl+Alt+/`
- `Edit.NextSuggestion` → `Alt+]`
- `Edit.PreviousSuggestion` → `Alt+[`
- `Edit.AcceptAllSuggestions` → `Ctrl+Enter`

## Extension Recommendations for Claude Integration

### Essential Extensions

1. **GitHub Copilot** (Microsoft)
   - Visual Studio Marketplace: Search "GitHub Copilot"
   - Provides AI-powered code completion
   - Supports Claude models through GitHub integration

2. **GitHub Copilot Chat** (Microsoft)
   - Visual Studio Marketplace: Search "GitHub Copilot Chat"
   - Enables conversational AI assistance
   - Real-time code explanations and suggestions

### Optional Extensions

1. **Visual Studio IntelliCode** (Microsoft)
   - Enhances AI suggestions
   - Works alongside Copilot

2. **CodeMaid** 
   - Code cleanup and organization
   - Complements AI-generated code

## Project-Specific Settings

### Enable AI Assistance for This Project

Create or modify `.vs/ServiciosSAPReport/v17/.suo` settings:

1. Right-click on the solution in Solution Explorer
2. Select **Properties**
3. Under **Configuration Properties**, ensure:
   - Build configuration is set to Debug or Release
   - Platform is AnyCPU

### IntelliSense Configuration

**Tools** → **Options** → **Text Editor** → **C#** → **IntelliSense**

Recommended settings:
- ☑ Show completion list after a character is typed
- ☑ Highlight matching portions of completion list items
- ☑ Show completion item filters
- ☑ Provide examples in completion list

## Using Claude in Different Scenarios

### Code Generation

**Inline Suggestion Mode:**
1. Start typing or write a comment
2. Wait for suggestion (gray text appears)
3. Press `Tab` to accept, `Esc` to dismiss

**Chat Mode:**
1. Open Copilot Chat: `View` → `GitHub Copilot Chat`
2. Ask questions like:
   - "Explain this SOAP service implementation"
   - "Generate unit tests for DataManager"
   - "Refactor this method to use async/await"

### Code Review

Select code block → Right-click → **GitHub Copilot** → **Explain This**

### Debugging Assistance

1. Set breakpoint
2. Start debugging (F5)
3. In Copilot Chat, describe the issue
4. Ask for debugging suggestions

## Advanced Configuration

### Model Selection (if available)

Some GitHub Copilot subscriptions allow model selection:

1. **Tools** → **Options** → **GitHub Copilot** → **Advanced**
2. Select model: **Claude 3.5 Sonnet** (if listed)
3. Adjust temperature/creativity settings

### Context Window Optimization

To help Claude understand your project better:

1. Keep related files open in tabs
2. Include relevant comments in code
3. Use descriptive variable and method names
4. Maintain consistent coding style

## File Associations

Ensure proper file associations for AI assistance:

**Tools** → **Options** → **Text Editor** → **File Extension**

Verify these are associated with C# editor:
- `.cs` → CSharp Editor
- `.csproj` → XML Editor
- `.svc` → XML Editor
- `.config` → XML Editor

## Workspace Settings

### Recommended Folder Structure

```
.vs/
├── ServiciosSAPReport/
│   └── v17/
│       ├── .suo (user settings)
│       └── .vsconfig (editor config)
```

### Privacy and Security

**Tools** → **Options** → **GitHub Copilot** → **Privacy**

Consider:
- ☐ Allow GitHub to use my code snippets for product improvements
- ☑ Enable telemetry
- Review data sharing preferences

## Troubleshooting

### Issue: Copilot not working

**Solution:**
1. Check extension status: `Extensions` → `Manage Extensions`
2. Verify GitHub login: `View` → `GitHub Copilot` → `Sign In`
3. Restart Visual Studio
4. Clear cache: Delete `.vs` folder contents (while VS is closed)

### Issue: Poor suggestions

**Solution:**
1. Add more context comments
2. Include example usage in comments
3. Ensure files are saved
4. Check IntelliSense is working (Ctrl+Space)

### Issue: Authentication errors

**Solution:**
1. Sign out: `View` → `GitHub Copilot` → `Sign Out`
2. Clear credentials: `Tools` → `Options` → `Source Control` → Clear
3. Sign in again
4. Authorize in browser

## Performance Tips

1. **Close unnecessary files** - Reduces context window processing
2. **Disable for large files** - If performance degrades
3. **Use focused comments** - Be specific about what you need
4. **Leverage file context** - Keep relevant files open

## API Integration (Alternative Method)

If using direct Anthropic API:

### Web.config Setup

```xml
<configuration>
  <appSettings>
    <add key="Anthropic.ApiKey" value="your-api-key" />
    <add key="Anthropic.Model" value="claude-3-5-sonnet-20241022" />
    <add key="Anthropic.MaxTokens" value="4096" />
  </appSettings>
</configuration>
```

### Sample Helper Class

Create `Helper/ClaudeHelper.cs`:

```csharp
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ServiciosSAPReport.Helper
{
    public class ClaudeHelper
    {
        private static readonly string ApiKey = ConfigurationManager.AppSettings["Anthropic.ApiKey"];
        private static readonly string Model = ConfigurationManager.AppSettings["Anthropic.Model"];
        
        public static async Task<string> GetCompletion(string prompt)
        {
            // Implementation for direct API calls
            // This is a simplified example
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-api-key", ApiKey);
                client.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
                
                var content = new StringContent(
                    $"{{\"model\":\"{Model}\",\"messages\":[{{\"role\":\"user\",\"content\":\"{prompt}\"}}],\"max_tokens\":1024}}",
                    Encoding.UTF8,
                    "application/json"
                );
                
                var response = await client.PostAsync("https://api.anthropic.com/v1/messages", content);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
```

## Resources

- **GitHub Copilot Docs**: https://docs.github.com/copilot
- **Visual Studio Extensions**: https://marketplace.visualstudio.com/
- **Anthropic Documentation**: https://docs.anthropic.com/
- **Claude API Reference**: https://docs.anthropic.com/claude/reference/

## Support

For issues:
- GitHub Copilot: https://github.com/github/copilot-docs
- Visual Studio: https://developercommunity.visualstudio.com/
- Anthropic: https://support.anthropic.com/

---

Last Updated: 2024-11-03
