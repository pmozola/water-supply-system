export interface Measurement {
  date: string;
  arduinoId: number;
  temperature: number;
  humidity: number;
  soilHumidity: number;
  lightIntensity: number;
}
