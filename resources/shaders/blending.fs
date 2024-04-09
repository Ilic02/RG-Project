#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;

void main()
{
    vec4 grayColor = vec4(0.5, 0.5, 0.5, 1.0);
    FragColor = texture(texture1, TexCoords) * grayColor;
}