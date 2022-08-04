import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaStudentClassComponent } from './lista-student-class.component';

describe('ListaStudentClassComponent', () => {
  let component: ListaStudentClassComponent;
  let fixture: ComponentFixture<ListaStudentClassComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListaStudentClassComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListaStudentClassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
