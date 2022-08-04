import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaStudentComponent } from './lista-student.component';

describe('ListaStudentComponent', () => {
  let component: ListaStudentComponent;
  let fixture: ComponentFixture<ListaStudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListaStudentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListaStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
